using Game.DAL.Contexts;
using Game.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Game.MVC.Controllers
{
    public class ShopController : Controller
    {
        readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {
            var category = _context.Categories.ToList();
            var play = _context.Plays.Include(p=>p.Category).AsQueryable();
            if (categoryId.HasValue)
            {
                play = play.Where(p => p.CategoryId == categoryId.Value);
            }
            var viewModels = new HomeVM
            {
                Categories = category,
                Plays = play.ToList(),
                CurrentCategoryId = categoryId,
            };
            return View(viewModels);
        }
    }
}
