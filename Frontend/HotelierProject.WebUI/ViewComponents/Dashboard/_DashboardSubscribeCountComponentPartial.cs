using HotelierProject.WebUI.Dtos.FollowersDto;
using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/didemgeziyor"),
                Headers =
    {
        { "x-rapidapi-key", "3d2cfc283emshe494339a4b6da16p15db1fjsne1d5b4b0fb0e" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDtos.followers;
                ViewBag.v2 = resultInstagramFollowersDtos.following;
            }

            //free total api count has finished thats why i am commenting this area

    //        var client2 = new HttpClient();
    //        var request2 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
    //            Headers =
    //{
    //    { "x-rapidapi-key", "3d2cfc283emshe494339a4b6da16p15db1fjsne1d5b4b0fb0e" },
    //    { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    //},
    //        };
    //        using (var response2 = await client2.SendAsync(request2))
    //        {
    //            response2.EnsureSuccessStatusCode();
    //            var body2 = await response2.Content.ReadAsStringAsync();
    //            var resultTwittterFollowersDto = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);
    //            ViewBag.v3 = resultTwittterFollowersDto.data.user_info.followers_count;
    //            ViewBag.v4 = resultTwittterFollowersDto.data.user_info.friends_count;
    //        }

    //        var client3 = new HttpClient();
    //        var request3 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fcjfollini%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false"),
    //            Headers =
    //{
    //    { "x-rapidapi-key", "3d2cfc283emshe494339a4b6da16p15db1fjsne1d5b4b0fb0e" },
    //    { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    //},
    //        };
    //        using (var response3 = await client3.SendAsync(request3))
    //        {
    //            response3.EnsureSuccessStatusCode();
    //            var body3 = await response3.Content.ReadAsStringAsync();
    //            var resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
    //            ViewBag.v5 = resultLinkedinFollowersDto.data.follower_count;
    //            ViewBag.v6 = resultLinkedinFollowersDto.data.connection_count;
    //        }

            var client4 = new HttpClient();
            var request4 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tiktok-scraper7.p.rapidapi.com/user/info?user_id=107955"),
                Headers =
    {
        { "x-rapidapi-key", "3d2cfc283emshe494339a4b6da16p15db1fjsne1d5b4b0fb0e" },
        { "x-rapidapi-host", "tiktok-scraper7.p.rapidapi.com" },
    },
            };
            using (var response4 = await client4.SendAsync(request4))
            {
                
                response4.EnsureSuccessStatusCode();
                var body4 = await response4.Content.ReadAsStringAsync();
                var resultTiktokFollowersDto = JsonConvert.DeserializeObject<ResultTiktokFollowersDto>(body4);
                ViewBag.v7 = resultTiktokFollowersDto.data.stats.followerCount;
                ViewBag.v8 = resultTiktokFollowersDto.data.stats.followingCount;

            }
            return View();
        }
    }
}
