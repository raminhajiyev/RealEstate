using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ExploreCitiesDto;
using RealEstate_Dapper_UI.DTOs.ProductDto;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _ExploreVCPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ExploreVCPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44393/api/PopularLocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultExploreCitiesDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
