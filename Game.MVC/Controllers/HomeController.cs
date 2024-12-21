using Game.DAL.Contexts;
using Game.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Game.MVC.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           var plays = _context.Plays.ToList();
           var categories = _context.Categories.ToList();
            var viewModel = new HomeVM {Plays = plays,Categories = categories};

            return View(viewModel);
        }
    }
}
