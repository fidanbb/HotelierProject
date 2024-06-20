using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;


namespace RapidApi.Consume.Controllers
{
    public class TestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new List<TestViewModel>();

            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "3d2cfc283emshe494339a4b6da16p15db1fjsne1d5b4b0fb0e" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                model=JsonConvert.DeserializeObject<List<TestViewModel>>(body);
                return View(model);
            }
           
        }
    }
}
