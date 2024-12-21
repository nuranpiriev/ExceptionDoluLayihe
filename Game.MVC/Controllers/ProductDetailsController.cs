using Microsoft.AspNetCore.Mvc;

namespace Game.MVC.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
