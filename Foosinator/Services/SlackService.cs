using System.Collections.Generic;
using SlackAPI;
using SlackAPI.Models;
using SlackAPI.Responses;

namespace Foosinator.Services
{
    public class SlackService
    {
        private readonly SlackClient _slackClient;

        public SlackService()
        {
            _slackClient = new SlackClient("xoxp-2312707600-2312707602-2319314455-a23438");
        }

        public List<Member> GetMembers()
        {
            UsersListResponse users = _slackClient.GetUsersList();

            return users.Members;
        }
    }
}