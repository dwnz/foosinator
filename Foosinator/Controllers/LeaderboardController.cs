using System.Web.Mvc;

namespace Foosinator.Controllers
{
    public class LeaderboardController : BaseController
    {
        // GET: Leaderboard
        public ActionResult Index()
        {
            return View(ResultsService.GetLeaderboard());
        }
    }
}