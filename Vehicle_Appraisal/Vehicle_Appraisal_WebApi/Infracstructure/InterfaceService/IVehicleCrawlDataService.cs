using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IVehicleCrawlDataService
    {
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleBMWCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleAudiCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleFordCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHondaCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHyundaiCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleLexusCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleMitsubishiCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleSuzukiCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleToyotaCrawlData(PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleVinfastCrawlData(PaginationVM paginationVM);
    }
}
