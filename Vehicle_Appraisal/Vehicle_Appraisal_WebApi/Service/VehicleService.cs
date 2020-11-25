using AutoMapper;
using com.sun.tools.corba.se.idl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
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

        public async Task<bool> BuyVehicle(int id)
        {
            var vehicleVM = await GetById(id);
            if (vehicleVM == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var vehicleDTO = _mapper.Map<VehicleDTO>(vehicleVM);
            vehicleDTO.isBought = true;
            vehicleDTO.UpdateAt = DateTime.Now;
            dbset.Update(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var vehicleDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            if (vehicleDTO == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var dbsetCondition = _dbContextDTO.Set<ConditionDTO>();
            var dbsetVehicleAppraisal = _dbContextDTO.Set<VehicleAppraisalDTO>();
            var condition = await dbsetCondition.Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            var vehicleAppraisal = await dbsetVehicleAppraisal.Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            foreach (var item in condition)
            {
                dbsetCondition.Remove(item);
            }
            foreach (var item in vehicleAppraisal)
            {
                dbsetVehicleAppraisal.Remove(item);
            }
            dbset.Remove(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<List<VehicleVM>> GetAll()
        {
            var listvehicleDTO = await dbset.Where(x => x.isBought == false).ToListAsync();
            var listvehicleVM = _mapper.Map<List<VehicleVM>>(listvehicleDTO);
            return listvehicleVM;
        }

        public async Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id)
        {
            var vehicleappraisalDTO = await _dbContextDTO.Set<VehicleAppraisalDTO>().Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            var vehicleappraisalVM = _mapper.Map<List<VehicleAppraisalVM>>(vehicleappraisalDTO);
            return vehicleappraisalVM;
        }

        public async Task<List<ConditionVM>> GetAllConditionById(int id)
        {
            var conditionDTO = await _dbContextDTO.Set<ConditionDTO>().Where(x => x.VehicleId.Equals(id)).AsNoTracking().ToListAsync();
            var conditionVM = _mapper.Map<List<ConditionVM>>(conditionDTO);
            return conditionVM;
        }

        public async Task<List<VehicleVM>> GetAllNotBuy()
        {
            var listvehicleDTO = await dbset.ToListAsync();
            var listvehicleVM = _mapper.Map<List<VehicleVM>>(listvehicleDTO);
            return listvehicleVM;
        }

        public async Task<VehicleVM> GetById(int id)
        {
            var vehicleDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isBought == false).AsNoTracking().SingleOrDefaultAsync();
            var vehicleVM = _mapper.Map<VehicleVM>(vehicleDTO);
            return vehicleVM;
        }

        public async Task<bool> Insert(VehicleVM vehicleVM)
        {
            var customerId = await _customerService.GetById(vehicleVM.CustomerId);
            var makeId = await _makeService.GetById(vehicleVM.MakeId);
            var modelId = await _modelService.GetById(vehicleVM.ModelId);
            var appuserId = await _userService.GetById(vehicleVM.AppUserId);
            if (customerId == null ||
                makeId == null ||
                modelId == null ||
                appuserId == null ||
                vehicleVM.VIN == null ||
                vehicleVM.Odometer == null ||
                vehicleVM.Engine == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var vehicleDTO = _mapper.Map<VehicleDTO>(vehicleVM);
            vehicleDTO.CreateAt = DateTime.Now;
            vehicleDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<List<VehicleVM>> Search(string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId)
        {
            if (customerId != null)
            {
                var vehicleDTO = await dbset.Where(x => x.CustomerId.ToString().Equals(customerId)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
            if (makeId != null)
            {
                var vehicleDTO = await dbset.Where(x => x.MakeId.ToString().Equals(makeId)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
            if (modelId != null)
            {
                var vehicleDTO = await dbset.Where(x => x.ModelId.ToString().Equals(modelId)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
            if (odometer != null)
            {
                var vehicleDTO = await dbset.Where(x => x.Odometer.Contains(odometer)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
            if (VIN != null)
            {
                var vehicleDTO = await dbset.Where(x => x.VIN.Contains(VIN)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
            if (engine != null)
            {
                var vehicleDTO = await dbset.Where(x => x.Engine.Contains(engine)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
            else
            {
                var vehicleDTO = await dbset.Where(x => x.AppUserId.ToString().Equals(appuserId)).Where(x => x.isBought == false).AsNoTracking().ToListAsync();
                var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
                return vehicleVM;
            }
        }

        public async Task<List<VehicleVM>> SearchDate(DateTime fromDate, DateTime toDate)
        {
            var vehicleDTO = await dbset.Where(x => x.UpdateAt.Date >= fromDate.Date).Where(x=>x.UpdateAt.Date <= toDate).ToListAsync();
            var vehicleVM = _mapper.Map<List<VehicleVM>>(vehicleDTO);
            return vehicleVM;
        }

        public async Task<bool> Update(VehicleVM vehicleVM, int id)
        {
            var checkValue = await GetById(id);
            var customerId = await _customerService.GetById(vehicleVM.CustomerId);
            var makeId = await _makeService.GetById(vehicleVM.MakeId);
            var modelId = await _modelService.GetById(vehicleVM.ModelId);
            var appuserId = await _userService.GetById(vehicleVM.AppUserId);
            if (checkValue == null ||
                customerId == null ||
                makeId == null ||
                modelId == null ||
                appuserId == null ||
                vehicleVM.VIN == null ||
                vehicleVM.Odometer == null ||
                vehicleVM.Engine == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var vehicleDTO = _mapper.Map<VehicleDTO>(vehicleVM);
            vehicleDTO.Id = id;
            vehicleDTO.UpdateAt = DateTime.Now;
            dbset.Update(vehicleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }
    }
}
