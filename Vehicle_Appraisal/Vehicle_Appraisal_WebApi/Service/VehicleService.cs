using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly DbContextDTO _dbContextDTO;
        private readonly ICustomerService _customerService;
        private readonly IMakeService _makeService;
        private readonly IModelService _modelService;
        private readonly IUserService _userService;
        private DbSet<VehicleDTO> dbset;
        private IMapper _mapper;
        public VehicleService(DbContextDTO dbContextDTO, IUserService userService, IMapper mapper, ICustomerService customerService, IMakeService makeService, IModelService modelService)
        {
            _userService = userService;
            _customerService = customerService;
            _makeService = makeService;
            _modelService = modelService;
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<VehicleDTO>();
        }

        public async Task<ApiResultVM<string>> BuyVehicle(int id)
        {
            var vehicleVM = await GetById(id);
            if (vehicleVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Vehicle doesn't exist");
            }
            var vehicleDTO = _mapper.Map<VehicleDTO>(vehicleVM);
            vehicleDTO.isBought = true;
            vehicleDTO.UpdateAt = DateTime.Now;
            dbset.Update(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Buy Success");
        }

        public async Task<ApiResultVM<string>> Delete(int id)
        {
            var vehicleDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            if (vehicleDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Vehicle doesn't exist");
            }
            var dbsetCondition = _dbContextDTO.Set<ConditionDTO>();
            var dbsetVehicleAppraisal = _dbContextDTO.Set<VehicleAppraisalDTO>();
            var condition = await dbsetCondition.Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            var appraisalValue = await dbsetVehicleAppraisal.Where(x => x.VehicleId.Equals(id)).AsNoTracking().FirstOrDefaultAsync();
            if (condition != null)
            {
                foreach (var item in condition)
                {
                    dbsetCondition.Remove(item);
                }
            }
            if (appraisalValue != null)
            {
                dbsetVehicleAppraisal.Remove(appraisalValue);
            }
            dbset.Remove(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Delete Success");
        }

        public async Task<List<VehicleVM>> GetAll()
        {
            var listvehicleDTO = await dbset.Where(x => x.isBought == false).ToListAsync();
            var listvehicleVM = _mapper.Map<List<VehicleVM>>(listvehicleDTO).OrderByDescending(x => x.CreateAt.Date).ToList();
            return listvehicleVM;
        }

        public async Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id)
        {
            var vehicleappraisalDTO = await _dbContextDTO.Set<VehicleAppraisalDTO>().Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            var vehicleappraisalVM = _mapper.Map<List<VehicleAppraisalVM>>(vehicleappraisalDTO);
            return vehicleappraisalVM;
        }

        public async Task<PageResultVM<ConditionVM>> GetAllConditionByIdPaging(int id, PaginationVM paginationVM)
        {
            var listConditionDTO = await _dbContextDTO.Set<ConditionDTO>().Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            var listConditionVM = _mapper.Map<List<ConditionVM>>(listConditionDTO).OrderByDescending(x => x.CreateAt.Date);
            var listConditionVMPagination = listConditionVM.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<ConditionVM>
            {
                Items = listConditionVMPagination,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = listConditionVM.Count()
            };
        }

        private async Task<List<VehicleVM>> VehicleJoinQuery(List<VehicleDTO> listVehicleDTO)
        {
            var listMakeDTO = await _dbContextDTO.makeDTOs.ToListAsync();
            var listModelDTO = await _dbContextDTO.modelDTOs.ToListAsync();
            var listCustomerDTO = await _dbContextDTO.customerDTOs.ToListAsync();
            var listUserDTO = await _dbContextDTO.appUserDTOs.ToListAsync();
            var listVehicleVM = (from vehicle in listVehicleDTO
                                 join make in listMakeDTO on vehicle.MakeId equals make.Id
                                 join model in listModelDTO on vehicle.ModelId equals model.Id
                                 join customer in listCustomerDTO on vehicle.CustomerId equals customer.Id
                                 join user in listUserDTO on vehicle.AppUserId equals user.Id
                                 select new VehicleVM
                                 {
                                     Id = vehicle.Id,
                                     CreateAt = vehicle.CreateAt,
                                     UpdateAt = vehicle.UpdateAt,
                                     MakeVM = _mapper.Map<MakeVM>(make),
                                     ModelVM = _mapper.Map<ModelVM>(model),
                                     CustomerVM = _mapper.Map<CustomerVM>(customer),
                                     AppUserVM = _mapper.Map<AppUserVM>(user),
                                     Engine = vehicle.Engine,
                                     Odometer = vehicle.Odometer,
                                     VIN = vehicle.VIN,
                                     isBought = vehicle.isBought
                                 }).ToList();
            return listVehicleVM;
        }

        public async Task<List<VehicleVM>> GetAllVehicleBought()
        {
            var listvehicleDTO = await dbset.Where(x => x.isBought == true).ToListAsync();
            var listvehicleVM = _mapper.Map<List<VehicleVM>>(listvehicleDTO).ToList();
            return listvehicleVM;
        }

        public async Task<PageResultVM<VehicleVM>> GetAllPaging(PaginationSearchVM paginationSearchVM)
        {
            var listVehicleDTO = await dbset.Where(x => x.isBought == false).ToListAsync();
            var listVehicleVM = await VehicleJoinQuery(listVehicleDTO);            
            if (paginationSearchVM.keyWord == null || paginationSearchVM.subjects == null)
            {
                var listVehicleVMPagination = listVehicleVM.Skip((paginationSearchVM.PageIndex - 1) * paginationSearchVM.PageSize).Take(paginationSearchVM.PageSize).OrderByDescending(x=>x.CreateAt).ToList();
                return new PageResultVM<VehicleVM>
                {
                    Items = listVehicleVMPagination,
                    PageIndex = paginationSearchVM.PageIndex,
                    TotalRecord = listVehicleVM.Count()
                };
            }
            else
            {
                var listVehicleVMSearch = new List<VehicleVM>();
                if (paginationSearchVM.subjects == "Customer")
                {
                    listVehicleVMSearch = listVehicleVM.Where(x => (x.CustomerVM.FirstName + " " + x.CustomerVM.LastName).Contains(paginationSearchVM.keyWord)).ToList();
                }
                if (paginationSearchVM.subjects == "Make")
                {
                    listVehicleVMSearch = listVehicleVM.Where(x => x.MakeVM.Name.Contains(paginationSearchVM.keyWord)).ToList();
                }
                if (paginationSearchVM.subjects == "Model")
                {
                    listVehicleVMSearch = listVehicleVM.Where(x => x.ModelVM.Name.Contains(paginationSearchVM.keyWord)).ToList();
                }
                if (paginationSearchVM.subjects == "Odometer")
                {
                    listVehicleVMSearch = listVehicleVM.Where(x => x.Odometer.Contains(paginationSearchVM.keyWord)).ToList();
                }
                if (paginationSearchVM.subjects == "VIN")
                {
                    listVehicleVMSearch = listVehicleVM.Where(x => x.VIN.Contains(paginationSearchVM.keyWord)).ToList();
                }
                if (paginationSearchVM.subjects == "Engine")
                {
                    listVehicleVMSearch = listVehicleVM.Where(x => x.Engine.Contains(paginationSearchVM.keyWord)).ToList();
                }
                
                var listVehicleVMPagination = listVehicleVMSearch.Skip((paginationSearchVM.PageIndex - 1) * paginationSearchVM.PageSize).Take(paginationSearchVM.PageSize).ToList();
                return new PageResultVM<VehicleVM>
                {
                    Items = listVehicleVMPagination,
                    PageIndex = paginationSearchVM.PageIndex,
                    TotalRecord = listVehicleVMSearch.Count()
                };
            }
        }

        public async Task<PageResultVM<VehicleVM>> GetAllVehicleBoughtPaging(DateTime fromDate, DateTime toDate, PaginationVM paginationVM)
        {
            if (fromDate.Year != 0001 || toDate.Year != 0001)
            {
                var listVehicleDTO = await dbset.Where(x => x.isBought == true).Where(x => x.UpdateAt.Date >= fromDate.Date).Where(x => x.UpdateAt.Date <= toDate).ToListAsync();
                var listVehicleVM = await VehicleJoinQuery(listVehicleDTO);
                var listVehicleVMPagination = listVehicleVM.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).OrderByDescending(x=>x.UpdateAt).ToList();
                return new PageResultVM<VehicleVM>
                {
                    Items = listVehicleVMPagination,
                    PageIndex = paginationVM.PageIndex,
                    TotalRecord = listVehicleVM.Count()
                };
            }
            else
            {
                var listVehicleDTO = await dbset.Where(x => x.isBought == true).ToListAsync();
                var listVehicleVM = await VehicleJoinQuery(listVehicleDTO);
                var listVehicleVMPagination = listVehicleVM.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).OrderByDescending(x=>x.UpdateAt).ToList();
                return new PageResultVM<VehicleVM>
                {
                    Items = listVehicleVMPagination,
                    PageIndex = paginationVM.PageIndex,
                    PageSize = paginationVM.PageSize,
                    TotalRecord = listVehicleVM.Count()
                };
            }
        }

        public async Task<VehicleVM> GetById(int id)
        {
            var vehicleDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isBought == false).AsNoTracking().SingleOrDefaultAsync();
            var vehicleVM = _mapper.Map<VehicleVM>(vehicleDTO);
            return vehicleVM;
        }

        public async Task<ApiResultVM<string>> Insert(VehicleVM vehicleVM)
        {
            var customerDTO = await _dbContextDTO.customerDTOs.Where(x => (x.FirstName + x.LastName).Equals(vehicleVM.CustomerVM.FirstName + vehicleVM.CustomerVM.LastName)).AsNoTracking().SingleOrDefaultAsync();
            var makeDTO = await _dbContextDTO.makeDTOs.Where(x => x.Name.Equals(vehicleVM.MakeVM.Name)).AsNoTracking().SingleOrDefaultAsync();
            var modelDTO = await _dbContextDTO.modelDTOs.Where(x => x.Name.Equals(vehicleVM.ModelVM.Name)).AsNoTracking().SingleOrDefaultAsync();
            var userDTO = await _dbContextDTO.appUserDTOs.Where(x => x.FullName.Equals(vehicleVM.AppUserVM.FullName)).AsNoTracking().SingleOrDefaultAsync();
            if (customerDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Customer doesn't exist");
            }
            if (makeDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Make doesn't exist");
            }
            if (modelDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Model doesn't exist");
            }
            if (userDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Users doesn't exist");
            }
            vehicleVM.CustomerId = customerDTO.Id;
            vehicleVM.MakeId = makeDTO.Id;
            vehicleVM.ModelId = modelDTO.Id;
            vehicleVM.AppUserId = userDTO.Id;
            var vehicleDTO = _mapper.Map<VehicleDTO>(vehicleVM);
            vehicleDTO.CreateAt = DateTime.Now;
            vehicleDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Insert Success");
        }

        public async Task<ApiResultVM<string>> Update(VehicleVM vehicleVM, int id)
        {
            var checkValue = await GetById(id);
            var customerDTO = await _dbContextDTO.customerDTOs.Where(x => (x.FirstName + x.LastName).Equals(vehicleVM.CustomerVM.FirstName + vehicleVM.CustomerVM.LastName)).AsNoTracking().SingleOrDefaultAsync();
            var makeDTO = await _dbContextDTO.makeDTOs.Where(x => x.Name.Equals(vehicleVM.MakeVM.Name)).AsNoTracking().SingleOrDefaultAsync();
            var modelDTO = await _dbContextDTO.modelDTOs.Where(x => x.Name.Equals(vehicleVM.ModelVM.Name)).AsNoTracking().SingleOrDefaultAsync();
            var userDTO = await _dbContextDTO.appUserDTOs.Where(x => x.FullName.Equals(vehicleVM.AppUserVM.FullName)).AsNoTracking().SingleOrDefaultAsync();
            if (checkValue == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Vehicle doesn't exist");
            }
            if (customerDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Customer doesn't exist");
            }
            if (makeDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Make doesn't exist");
            }
            if (modelDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Model doesn't exist");
            }
            if (userDTO == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Users doesn't exist");
            }
            vehicleVM.CustomerId = customerDTO.Id;
            vehicleVM.MakeId = makeDTO.Id;
            vehicleVM.ModelId = modelDTO.Id;
            vehicleVM.AppUserId = userDTO.Id;
            var vehicleDTO = _mapper.Map<VehicleDTO>(vehicleVM);
            vehicleDTO.Id = id;
            vehicleDTO.UpdateAt = DateTime.Now;
            dbset.Update(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Update Success");
        }

        public async Task<List<VehicleVM>> GetAllNotBuy()
        {
            var listVehicleDTO = await dbset.ToListAsync();
            var listVehicleVM = _mapper.Map<List<VehicleVM>>(listVehicleDTO);
            return listVehicleVM;
        }
    }
}
