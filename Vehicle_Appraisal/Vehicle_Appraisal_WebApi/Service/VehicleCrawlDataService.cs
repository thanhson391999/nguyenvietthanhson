using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
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

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleAudiCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Audi")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleBMWCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("BMW")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleFordCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Ford")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHondaCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Honda")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHyundaiCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Hyundai")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleLexusCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Lexus")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleMitsubishiCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Mitsubishi")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleSuzukiCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Suzuki")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleToyotaCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Toyota")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleVinfastCrawlData(PaginationVM paginationVM)
        {
            var vehicleCrawlDataDTOs = await dbset.Where(x => x.Name.Contains("Vinfast")).ToListAsync();
            var vehicleCrawlDataVMs = _mapper.Map<List<VehicleCrawlDataVM>>(vehicleCrawlDataDTOs);
            var vehicleCrawlDataVMPaging = vehicleCrawlDataVMs.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<VehicleCrawlDataVM>
            {
                Items = vehicleCrawlDataVMPaging,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = vehicleCrawlDataVMs.Count()
            };
        }
    }
}
