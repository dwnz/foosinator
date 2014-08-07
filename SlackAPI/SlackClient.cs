using RestSharp;
using RestSharp.Deserializers;
using SlackAPI.Constants;
using SlackAPI.Responses;

namespace SlackAPI
{
    public class SlackClient
    {
        private readonly string _token;
        private RestClient restClient;

        public SlackClient(string token)
        {
            _token = token;
            restClient = new RestClient("https://slack.com/api/");

            restClient.DefaultParameters.Add(new Parameter
                                             {
                                                 Name = "token",
                                                 Type = ParameterType.QueryString,
                                                 Value = _token
                                             });
        }

        public UsersListResponse GetUsersList()
        {
            RestRequest request = new RestRequest("users.list", Method.GET);

            IRestResponse<UsersListResponse> response = restClient.Execute<UsersListResponse>(request);

            return response.Data;
        }
    }
}
