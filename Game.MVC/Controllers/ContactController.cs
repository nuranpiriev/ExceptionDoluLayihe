using Microsoft.AspNetCore.Mvc;

namespace Game.MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
