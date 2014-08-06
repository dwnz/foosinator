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
                                              Players = PlayersService.GetAllPlayers(),
                                              ActiveGame = GameService.GetActiveGame()
                                          };

            return View(homeViewModel);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {
            Game newGame = GameService.CreateGame(model.PlayerId, model.TeamPlayerId, model.VsPlayerId, model.VsPlayerTeamMateId);
            return RedirectToAction("Index", "Game", new
                                                     {
                                                         id = newGame.Id
                                                     });
        }
    }
}
