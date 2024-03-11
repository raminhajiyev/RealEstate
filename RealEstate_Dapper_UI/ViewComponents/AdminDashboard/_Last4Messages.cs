using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ProductDto;
using RealEstate_Dapper_UI.DTOs.UserContactDto;

namespace RealEstate_Dapper_UI.ViewComponents.AdminDashboard
{
    public class _Last4Messages: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Last4Messages(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44393/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4MessagesDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
