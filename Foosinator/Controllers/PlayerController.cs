using System.Linq;
using System.Web.Mvc;
using Foosinator.Models;
using SlackAPI.Models;

namespace Foosinator.Controllers
{
    public class PlayerController : BaseController
    {
        public ActionResult Create()
        {
            CreatePlayerViewModel createPlayerViewModel = new CreatePlayerViewModel
                                                          {
                                                              Members = SlackService.GetMembers()
                                                          };

            return View(createPlayerViewModel);
        }

        public ActionResult Add(string id)
        {
            Member member = SlackService.GetMembers().Single(x => x.Id == id);


            if (string.IsNullOrEmpty(member.Name))
            {
                ModelState.AddModelError("Name", "Name cannot be empty");
            }

            if (PlayersService.HasPlayerWithName(member.Name))
            {
                ModelState.AddModelError("Name", "Someone has that name");
            }

            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            
            Player player = PlayersService.CreatePlayer(member);

            return RedirectToAction("Index", "Home", new { player = player.Id });
        }
    }
}