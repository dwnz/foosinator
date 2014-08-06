using System.Web.Mvc;
using Foosinator.Models;

namespace Foosinator.Controllers
{
    public class PlayerController : BaseController
    {
        public ActionResult Create()
        {
            return View(new Player());
        }

        [HttpPost]
        public ActionResult Create(Player player)
        {
            if (string.IsNullOrEmpty(player.Name))
            {
                ModelState.AddModelError("Name", "Name cannot be empty");
            }

            if (PlayersService.HasPlayerWithName(player.Name))
            {
                ModelState.AddModelError("Name", "Someone has that name");
            }

            if (!ModelState.IsValid)
            {
                return View(player);
            }


            player = PlayersService.CreatePlayer(player.Name);

            return RedirectToAction("Index", "Home", new { player = player.Id });
        }
    }
}