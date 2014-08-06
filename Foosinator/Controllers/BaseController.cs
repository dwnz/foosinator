using System.Web.Mvc;
using Foosinator.Services;

namespace Foosinator.Controllers
{
    public class BaseController : Controller
    {
        protected PlayersService _playersService;
        protected GameService _gameService;

        public BaseController()
        {
            _playersService = new PlayersService();
            _gameService = new GameService();
        }
    }
}