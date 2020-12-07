using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IVehicleCrawlDataServiceApiClient
    {
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleBMWCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleAudiCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleFordCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHondaCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHyundaiCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleLexusCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleMitsubishiCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleSuzukiCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleToyotaCrawlData(string token, PaginationVM paginationVM);
        Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleVinfastCrawlData(string token, PaginationVM paginationVM);
    }
}
