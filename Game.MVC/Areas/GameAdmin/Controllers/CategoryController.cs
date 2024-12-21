using Game.BL.Service.Abstractions;
using Game.DAL.Contexts;
using Game.DAL.Models;
using Game.MVC.Controllers;
using Game.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Game.MVC.Areas.GameAdmin.Controllers
{
    public class CategoryController : Controller
    {
        readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        

        

        [Area("GameAdmin")]
        public async Task<IActionResult> Index()
        {
           var categories =await _context.Categories.ToListAsync();
            var viewM = new HomeVM
            {
                Categories = categories.ToList()
            };
            return View(viewM);
        }


        public async Task<IActionResult> Delete(int Id)
        {
            Category? game = await _context.Categories.FirstOrDefaultAsync(g => g.Id == Id);
            if (game == null)
            {
                return NotFound("Category not found.");
            }

            _context.Categories.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Category");

        }

    }
}
