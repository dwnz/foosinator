using System;
using System.Web.Mvc;

namespace Foosinator.Controllers
{
    public class GameController : BaseController
    {
        public ActionResult Index(Guid id)
        {
            return View(_gameService.GetGame(id));
        }
    }
}