using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ProductDto;
using RealEstate_Dapper_UI.DTOs.WhoWeAreDto;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _AboutUsVCPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsVCPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult>  InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44393/api/WhoWeAreDetail");
            var responseMessage2 = await client2.GetAsync("https://localhost:44393/api/WhoWeAreService");
            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDtos>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultWhoWeAreServiceDtos>>(jsonData2);

                ViewBag.title=values.Select(x=> x.Title).FirstOrDefault();
                ViewBag.subtitle=values.Select(x=> x.Subtitle).FirstOrDefault();
                ViewBag.description1=values.Select(x=> x.Description1).FirstOrDefault();
                ViewBag.description2=values.Select(x=> x.Description2).FirstOrDefault();
                return View(values2);
            }
            return View();
        }
    }
}
