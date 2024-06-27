namespace HotelierProject.WebUI.Dtos.FollowersDto
{
    public class ResultTiktokFollowersDto
    {


        public Data data { get; set; }

        public class Data
        {
            public Stats stats { get; set; }
        }


        public class Stats
        {
            public int followingCount { get; set; }
            public int followerCount { get; set; }
       
        }

    }
}
