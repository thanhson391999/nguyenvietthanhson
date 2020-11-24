using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Vehicle_Appraisal_WebApi.DTOs;

namespace CrawlDataVehicle
{
    public class Program
    {
        private static DbContextDTO _dbContextDTO;
        private static DbSet<VehicleCrawlDataDTO> dbset;
        public static void CrawlData(string url)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDoc = htmlWeb.Load(url);
            var listvehicle = htmlDoc.DocumentNode
                .QuerySelectorAll("div.product-list.mb-2.card").ToList();
            foreach (var item in listvehicle)
            {
                var vehicleCrawlData = new VehicleCrawlDataDTO()
                {
                    Name = item?.QuerySelector("a.link-title")?.InnerText,
                    Image = item?.QuerySelector("img.card-img-top.card-img-back.lazy")?.Attributes["data-src"]?.Value,
                    Value = item?.QuerySelector("td.text-right")?.InnerText,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                };
                dbset.AddAsync(vehicleCrawlData);
            }
        }
        private IConfiguration configuration { get; set; }

        static void Main(string[] args)
        {
            var service = new ServiceCollection();
            service.AddDbContext<DbContextDTO>(opt => opt.UseSqlServer("Server=DESKTOP-9CB2CPM;Database=VehicleAppraisal;Trusted_Connection=True;"));
            var serviceProvider = service.BuildServiceProvider();
            _dbContextDTO = serviceProvider.GetService<DbContextDTO>();
            dbset = _dbContextDTO.Set<VehicleCrawlDataDTO>();
            if (dbset.ToList().Where(x => x.CreateAt.Day.Equals(DateTime.Now.Day)).Count() == 0)
            {
                foreach (var itemDB in dbset.ToList())
                {
                    dbset.Remove(itemDB);
                }
                CrawlData(@"https://tinbanxe.vn/audi");
                CrawlData(@"https://tinbanxe.vn/vinfast");
                CrawlData(@"https://tinbanxe.vn/bmw");
                CrawlData(@"https://tinbanxe.vn/ford");
                CrawlData(@"https://tinbanxe.vn/honda");
                CrawlData(@"https://tinbanxe.vn/lexus");
                CrawlData(@"https://tinbanxe.vn/suzuki");
                CrawlData(@"https://tinbanxe.vn/toyota");
                CrawlData(@"https://tinbanxe.vn/hyundai");
                CrawlData(@"https://tinbanxe.vn/mitsubishi");
                _dbContextDTO.SaveChangesAsync();
            }
        }
    }
}
