using AutoMapper;
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

        public async Task<bool> Delete(int id)
        {
            var VehicleAppraisalVM = await GetById(id);
            if (VehicleAppraisalVM == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var VehicleAppraisalDTO = _mapper.Map<VehicleAppraisalDTO>(VehicleAppraisalVM);
            dbset.Remove(VehicleAppraisalDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<List<VehicleAppraisalVM>> GetAll()
        {
            var listVehicleAppraisalDTO = await dbset.ToListAsync();
            var listVehicleAppraisalVM = _mapper.Map<List<VehicleAppraisalVM>>(listVehicleAppraisalDTO);
            return listVehicleAppraisalVM;
        }

        public async Task<VehicleAppraisalVM> GetById(int id)
        {
            var VehicleAppraisalDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            var VehicleAppraisalVM = _mapper.Map<VehicleAppraisalVM>(VehicleAppraisalDTO);
            return VehicleAppraisalVM;
        }

        public async Task<bool> Insert(VehicleAppraisalVM VehicleAppraisalVM)
        {
            var vehicle = await _vehicleService.GetById(VehicleAppraisalVM.VehicleId);
            if (vehicle == null || VehicleAppraisalVM.AppraisalValue == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var checkValue = await dbset.Where(x=>x.VehicleId.Equals(vehicle.Id)).AsNoTracking().SingleOrDefaultAsync();
            if (checkValue != null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var VehicleAppraisalDTO = _mapper.Map<VehicleAppraisalDTO>(VehicleAppraisalVM);
            VehicleAppraisalDTO.CreateAt = DateTime.Now; 
            VehicleAppraisalDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(VehicleAppraisalDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(VehicleAppraisalVM VehicleAppraisalVM, int id)
        {
            var checkValue = await GetById(id);
            var vehicleId = await _vehicleService.GetById(VehicleAppraisalVM.VehicleId);
            if (checkValue == null || vehicleId == null || VehicleAppraisalVM.AppraisalValue == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var VehicleAppraisalDTO = _mapper.Map<VehicleAppraisalDTO>(VehicleAppraisalVM);
            VehicleAppraisalDTO.Id = id;
            VehicleAppraisalDTO.UpdateAt = DateTime.Now;
            dbset.Update(VehicleAppraisalDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }
    }
}
