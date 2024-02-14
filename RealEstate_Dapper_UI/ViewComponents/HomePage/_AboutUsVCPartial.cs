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
            var responseMessage = await client.GetAsync("https://localhost:44393/api/WhoWeAreDetail");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDtos>>(jsonData);
                ViewBag.title=values.Select(x=> x.Title).FirstOrDefault();
                ViewBag.subtitle=values.Select(x=> x.Subtitle).FirstOrDefault();
                ViewBag.description1=values.Select(x=> x.Description1).FirstOrDefault();
                ViewBag.description2=values.Select(x=> x.Description2).FirstOrDefault();
                return View();
            }
            return View();
        }
    }
}
