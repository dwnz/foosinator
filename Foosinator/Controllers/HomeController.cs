using System.Web.Mvc;
using Foosinator.Models;

namespace Foosinator.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
                                          {
                                              Players = _playersService.GetAllPlayers(),
                                              HasActiveGame = _gameService.HasActiveGame()
                                          };

            return View(homeViewModel);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {
            Game newGame = _gameService.CreateGame(model.PlayerId, model.TeamPlayerId, model.VsPlayerId, model.VsPlayerTeamMateId);
            return RedirectToAction("Index", "Game", new
                                                     {
                                                         id = newGame.Id
                                                     });
        }
    }
}
