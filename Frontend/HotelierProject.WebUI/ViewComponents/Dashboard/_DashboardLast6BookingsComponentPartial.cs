using HotelierProject.WebUI.Dtos.BookingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast6BookingsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardLast6BookingsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5073/api/Booking/Last6Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast6BookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
