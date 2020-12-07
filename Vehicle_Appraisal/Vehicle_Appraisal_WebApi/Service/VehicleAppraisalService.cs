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
    public class VehicleAppraisalService : IVehicleAppraisalService
    {
        private readonly DbContextDTO _dbContextDTO;
        private readonly IVehicleService _vehicleService;
        private DbSet<VehicleAppraisalDTO> dbset;
        private IMapper _mapper;
        public VehicleAppraisalService(DbContextDTO dbContextDTO, IMapper mapper, IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<VehicleAppraisalDTO>();
        }

        public async Task<ApiResultVM<string>> Delete(int id)
        {
            var VehicleAppraisalVM = await GetById(id);
            if (VehicleAppraisalVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Appraisal value doesn't exist");
            }
            var VehicleAppraisalDTO = _mapper.Map<VehicleAppraisalDTO>(VehicleAppraisalVM);
            dbset.Remove(VehicleAppraisalDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Delete Success");
        }

        public async Task<List<VehicleAppraisalVM>> GetAll()
        {
            var listVehicleAppraisalDTO = await dbset.ToListAsync();
            var listVehicleAppraisalVM = _mapper.Map<List<VehicleAppraisalVM>>(listVehicleAppraisalDTO);
            return listVehicleAppraisalVM;
        }

        public Task<PageResultVM<VehicleAppraisalVM>> GetAllPaging(PaginationVM paginationVM)
        {
            throw new NotImplementedException();
        }

        public async Task<VehicleAppraisalVM> GetById(int id)
        {
            var VehicleAppraisalDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            var VehicleAppraisalVM = _mapper.Map<VehicleAppraisalVM>(VehicleAppraisalDTO);
            return VehicleAppraisalVM;
        }

        public async Task<ApiResultVM<string>> Insert(VehicleAppraisalVM VehicleAppraisalVM)
        {
            var vehicle = await _vehicleService.GetById(VehicleAppraisalVM.VehicleId);
            if (vehicle == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Vehicle doesn't exist to insert appraisal value");
            }
            var checkValue = await dbset.Where(x => x.VehicleId.Equals(vehicle.Id)).AsNoTracking().SingleOrDefaultAsync();
            if (checkValue != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Vehicle had an appraisal value");
            }
            var VehicleAppraisalDTO = _mapper.Map<VehicleAppraisalDTO>(VehicleAppraisalVM);
            VehicleAppraisalDTO.CreateAt = DateTime.Now;
            VehicleAppraisalDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(VehicleAppraisalDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Insert Success");
        }

        public async Task<ApiResultVM<string>> Update(VehicleAppraisalVM VehicleAppraisalVM, int id)
        {
            var checkValue = await GetById(id);
            var vehicleId = await _vehicleService.GetById(VehicleAppraisalVM.VehicleId);
            if (checkValue == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Appraisal value doesn't exist");
            }
            if (vehicleId == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Vehicle doesn't exist to update appraisal value");
            }
            var VehicleAppraisalDTO = _mapper.Map<VehicleAppraisalDTO>(VehicleAppraisalVM);
            VehicleAppraisalDTO.Id = id;
            VehicleAppraisalDTO.UpdateAt = DateTime.Now;
            dbset.Update(VehicleAppraisalDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Update Success");
        }
    }
}
