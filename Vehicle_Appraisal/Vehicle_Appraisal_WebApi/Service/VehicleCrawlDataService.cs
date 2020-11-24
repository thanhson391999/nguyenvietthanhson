using AutoMapper;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
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
    public class VehicleCrawlDataService : IVehicleCrawlDataService
    {
        private DbSet<VehicleCrawlDataDTO> dbset;
        private IMapper _mapper;
        public VehicleCrawlDataService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _mapper = mapper;
            dbset = dbContextDTO.Set<VehicleCrawlDataDTO>();
        }

        public async Task<List<VehicleCrawlDataVM>> GetAllVehicleCrawlData()
        {
            var vehicleCrawlDataDTO = await dbset.ToListAsync();
            var vehicleCrawlDataVM = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTO);
            return vehicleCrawlDataVM;
        }
    }
}
