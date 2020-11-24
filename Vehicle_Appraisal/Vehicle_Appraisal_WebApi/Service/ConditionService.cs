﻿using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class ConditionService : IConditionService
    {
        private readonly DbContextDTO _dbContextDTO;
        private readonly IVehicleService _vehicleService;
        private DbSet<ConditionDTO> dbset;
        private IMapper _mapper;
        public ConditionService(DbContextDTO dbContextDTO, IMapper mapper, IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<ConditionDTO>();
        }
        public async Task<bool> Delete(int id)
        {
            var ConditionVM = await GetById(id);
            if (ConditionVM == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var ConditionDTO = _mapper.Map<ConditionDTO>(ConditionVM);
            dbset.Remove(ConditionDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<List<ConditionVM>> GetAll()
        {
            var listConditionDTO = await dbset.ToListAsync();
            var listConditionVM = _mapper.Map<List<ConditionVM>>(listConditionDTO);
            return listConditionVM;
        }

        public async Task<ConditionVM> GetById(int id)
        {
            var ConditionDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            var ConditionVM = _mapper.Map<ConditionVM>(ConditionDTO);
            return ConditionVM;
        }

        public async Task<bool> Insert(ConditionVM conditionVM)
        {
            var vehicleId = await _vehicleService.GetById(conditionVM.VehicleId);
            if (vehicleId == null ||
                conditionVM.Type == null ||
                conditionVM.ImagePath == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            if (conditionVM.Note == null)
            {
                conditionVM.Note = "Không";
            }
            var ConditionDTO = _mapper.Map<ConditionDTO>(conditionVM);
            ConditionDTO.CreateAt = DateTime.Now;
            ConditionDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(ConditionDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(ConditionVM conditionVM, int id)
        {
            var checkValue = await GetById(id);
            var vehicleId = await _vehicleService.GetById(conditionVM.VehicleId);
            if (checkValue == null ||
                vehicleId == null ||
                conditionVM.Type == null ||
                conditionVM.ImagePath == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            if (conditionVM.Note == null)
            {
                conditionVM.Note = "Không";
            }
            var ConditionDTO = _mapper.Map<ConditionDTO>(conditionVM);
            ConditionDTO.Id = id;
            ConditionDTO.UpdateAt = DateTime.Now;
            dbset.Update(ConditionDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<string> UploadImage(IFormFile file)
        {
            string name = file.FileName.Split('\\').LastOrDefault();
            string path = Path.Combine("E:/Github/ss-training-son/Vehicle_Appraisal/Vehicle_Appraisal_WebMVC/wwwroot/Images/" + name);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return name;
        }
    }
}