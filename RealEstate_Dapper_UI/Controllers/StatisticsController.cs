using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            #region ActiveCategory
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44393/api/Statistics/ActiveCategoryCount");
            
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.activeCategory=jsonData;
            #endregion

            #region BuyCount
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44393/api/Statistics/BuyCount");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.buyCount = jsonData2;
            #endregion

            #region RentCount
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44393/api/Statistics/RentCount");

            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.rentCount = jsonData3;
            #endregion

            #region DailyRentCount
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44393/api/Statistics/DailyRentCount");

            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.dailyRent = jsonData4;
            #endregion

            #region WeeklyRentCount
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44393/api/Statistics/WeeklyRentCount");

            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.weeklyRent = jsonData5;
            #endregion

            #region PassiveCategoryCount
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44393/api/Statistics/PassiveCategoryCount");

            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.passiveCategory = jsonData6;
            #endregion
            return View();
        }
    }
}
