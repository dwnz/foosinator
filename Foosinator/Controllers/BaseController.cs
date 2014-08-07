using System.Web.Mvc;
using Foosinator.Services;

namespace Foosinator.Controllers
{
    public class BaseController : Controller
    {
        protected PlayersService PlayersService;
        protected GameService GameService;
        protected ResultsService ResultsService;
        protected SlackService SlackService;

        public BaseController()
        {
            PlayersService = new PlayersService();
            GameService = new GameService();
            ResultsService = new ResultsService();
            SlackService = new SlackService();
        }
    }
}