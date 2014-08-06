using System;
using System.Web.Mvc;

namespace Foosinator.Controllers
{
    public class GameController : BaseController
    {
        public ActionResult Index(Guid id)
        {
            return View(GameService.GetGame(id));
        }

        public ActionResult Cancel(Guid id)
        {
            GameService.CancelGame(id);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Done(Guid game, Guid player)
        {
            GameService.GameDone(game, player);
            return RedirectToAction("Index", "Home");
        }
    }
}