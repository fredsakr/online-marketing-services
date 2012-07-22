namespace OnlineMarketingServices.Models.Twitter.Search
{
    public class Result
    {
        public string from_user { get; set; }
        public long from_user_id { get; set; }
        public string from_user_name { get; set; }
        public long id { get; set; }
        public string id_str { get; set; }
        public string source { get; set; }
        public string text { get; set; }
        public long to_user { get; set; }
        public string to_user_str { get; set; }
    }
}