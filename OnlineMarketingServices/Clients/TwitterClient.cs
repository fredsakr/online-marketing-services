using OnlineMarketingServices.Models.Twitter.Search;
using RestSharp;

namespace OnlineMarketingServices.Clients
{
    public class TwitterClient
    {
        private RestSharp.RestClient _client;

        public TwitterClient()
        {
            _client = new RestClient
                          {
                              BaseUrl = "http://search.twitter.com/",
                              Authenticator =
                                  RestSharp.Authenticators.OAuth1Authenticator.ForAccessToken("",
                                                                                              "",
                                                                                              "",
                                                                                              "")
                          };
        }

        public ListResponse SearchTwitter(string searchTerm)
        {
            RestSharp.RestRequest request = new RestRequest(Method.GET)
                                                {
                                                    RequestFormat = DataFormat.Json,
                                                    Resource = string.Format("search.json?q=%40{0}", searchTerm)
                                                };

            IRestResponse<ListResponse> response = _client.Execute<ListResponse>(request);

            return response.Data;
        }
    }
}