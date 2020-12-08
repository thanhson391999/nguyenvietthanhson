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
    public class CustomerService : ICustomerService
    {
        private readonly DbContextDTO _dbContextDTO;
        private DbSet<CustomerDTO> dbset;
        private IMapper _mapper;
        public CustomerService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<CustomerDTO>();
        }

        public async Task<ApiResultVM<string>> Delete(int id)
        {
            var customerVM = await GetById(id);
            if (customerVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Customer doesn't exist");
            }
            var checkConstraint = _dbContextDTO.Set<VehicleDTO>().Where(x => x.CustomerId.Equals(id)).Where(x => x.isBought == false).AsNoTracking().FirstOrDefault();
            if (checkConstraint != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Can't delete because customer is existing in vehicle");
            }
            var customerDTO = _mapper.Map<CustomerDTO>(customerVM);
            customerDTO.isDelete = true;
            customerDTO.UpdateAt = DateTime.Now;
            dbset.Update(customerDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Delete Success");
        }

        public async Task<List<CustomerVM>> GetAll()
        {
            var listcustomerDTO = await dbset.Where(x => x.isDelete == false).ToListAsync();
            var listcustomerVM = _mapper.Map<List<CustomerVM>>(listcustomerDTO).OrderByDescending(x=>x.CreateAt.Date).ToList();
            return listcustomerVM;
        }

        public async Task<List<CustomerVM>> GetAllNotDelete()
        {
            var listcustomerDTO = await dbset.ToListAsync();
            var listcustomerVM = _mapper.Map<List<CustomerVM>>(listcustomerDTO);
            return listcustomerVM;
        }

        public async Task<PageResultVM<CustomerVM>> GetAllPaging(PaginationSearchVM paginationSearchVM)
        {
            if (paginationSearchVM.keyWord == null || paginationSearchVM.subjects == null)
            {
                var listCustomerVM = await GetAll();
                var listCustomerVMPaging = listCustomerVM.Skip((paginationSearchVM.PageIndex - 1) * paginationSearchVM.PageSize).Take(paginationSearchVM.PageSize).ToList();
                return new PageResultVM<CustomerVM>
                {
                    Items = listCustomerVMPaging,
                    PageIndex = paginationSearchVM.PageIndex,
                    TotalRecord = listCustomerVM.Count()
                };
            }
            else
            {
                var listCustomerVM = new List<CustomerVM>();
                if (paginationSearchVM.subjects == "Name")
                {
                    var listCustomerDTO = await dbset.Where(x => (x.FirstName + " " + x.LastName).Contains(paginationSearchVM.keyWord)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                    listCustomerVM = _mapper.Map<List<CustomerVM>>(listCustomerDTO);
                }
                if (paginationSearchVM.subjects == "Phone")
                {
                    var listCustomerDTO = await dbset.Where(x => (x.Phone).Contains(paginationSearchVM.keyWord)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                    listCustomerVM = _mapper.Map<List<CustomerVM>>(listCustomerDTO);
                }
                if (paginationSearchVM.subjects == "Email")
                {
                    var listCustomerDTO = await dbset.Where(x => (x.Email).Contains(paginationSearchVM.keyWord)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                    listCustomerVM = _mapper.Map<List<CustomerVM>>(listCustomerDTO);
                }
                if (paginationSearchVM.subjects == "Address")
                {
                    var listCustomerDTO = await dbset.Where(x => (x.Address1.Contains(paginationSearchVM.keyWord) || x.Address2.Contains(paginationSearchVM.keyWord))).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                    listCustomerVM = _mapper.Map<List<CustomerVM>>(listCustomerDTO);
                }
                if (paginationSearchVM.subjects == "City")
                {
                    var listCustomerDTO = await dbset.Where(x => (x.City).Contains(paginationSearchVM.keyWord)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                    listCustomerVM = _mapper.Map<List<CustomerVM>>(listCustomerDTO);
                }
                if (paginationSearchVM.subjects == "Country")
                {
                    var listCustomerDTO = await dbset.Where(x => (x.Country).Contains(paginationSearchVM.keyWord)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                    listCustomerVM = _mapper.Map<List<CustomerVM>>(listCustomerDTO);
                }
                var listCustomerVMPaging = listCustomerVM.Skip((paginationSearchVM.PageIndex - 1) * paginationSearchVM.PageSize).Take(paginationSearchVM.PageSize).ToList();
                return new PageResultVM<CustomerVM>
                {
                    Items = listCustomerVMPaging,
                    PageIndex = paginationSearchVM.PageIndex,
                    TotalRecord = listCustomerVM.Count()
                };
            }
        }

        public async Task<CustomerVM> GetById(int id)
        {
            var customerDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefaultAsync();
            var customerVM = _mapper.Map<CustomerVM>(customerDTO);
            return customerVM;
        }

        public async Task<ApiResultVM<string>> Insert(CustomerVM customerVM)
        {
            var checkCustomer = await dbset.Where(x => (x.FirstName + " " + x.LastName).Equals(customerVM.FirstName + " " + customerVM.LastName)).AsNoTracking().FirstOrDefaultAsync();
            if (checkCustomer != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Customer's name already exist");
            }
            if (customerVM.Address2 == null)
            {
                customerVM.Address2 = "Không";
            }
            var customerDTO = _mapper.Map<CustomerDTO>(customerVM);
            customerDTO.CreateAt = DateTime.Now;
            customerDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(customerDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Insert Success");
        }

        public async Task<ApiResultVM<string>> Update(CustomerVM customerVM, int id)
        {
            var checkValue = await GetById(id);
            if (checkValue == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Customer doesn't exist");
            }
            var checkCustomer = await dbset.Where(x => x.Id != (id)).Where(x => (x.FirstName + " " + x.LastName).Equals(customerVM.FirstName + " " + customerVM.LastName)).AsNoTracking().FirstOrDefaultAsync();
            if (checkCustomer != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Customer's name already exist");
            }
            if (customerVM.Address2 == null)
            {
                customerVM.Address2 = "Không";
            }
            var customerDTO = _mapper.Map<CustomerDTO>(customerVM);
            customerDTO.Id = id;
            customerDTO.UpdateAt = DateTime.Now;
            dbset.Update(customerDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Update Success");
        }
    }
}
