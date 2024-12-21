using Microsoft.AspNetCore.Mvc;

namespace Game.MVC.Areas.GameAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("GameAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
