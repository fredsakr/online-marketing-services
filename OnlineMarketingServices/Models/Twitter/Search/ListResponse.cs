using System.Collections.Generic;

namespace OnlineMarketingServices.Models.Twitter.Search
{
    public class ListResponse
    {
        public string next_page { get; set; }
        public int? page { get; set; }
        public string query { get; set; }
        public string refresh_url { get; set; }
        public List<Result> results { get; set; }
    }
}