using Microsoft.AspNetCore.Mvc;

namespace Game.MVC.Areas.GameAdmin.Controllers
{
    public class PlayController : Controller
    {
        [Area("GameAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
