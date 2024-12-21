using Game.BL.Service.Abstractions;
using Game.DAL.Contexts;
using Game.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL.Service.Concretes
{
    public class CategoryService : ICategoryService
    {
        readonly AppDbContext _context;
        readonly DbSet<Category> _dbSet;
        public CategoryService(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Category>();
        }
        public async Task AddCategoryAsync(Category category)
        {
            await _dbSet.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) return false;

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task EditCategoryAsync(int id, Category category)
        {
            var existCategory =await _dbSet.FindAsync(id);
            if (existCategory == null)
            {
                throw new Exception($"Cannot find category with {id} Id");
            }
            _context.Entry(existCategory).CurrentValues.SetValues(category);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Category>> GetAllCategoriesAsync()
        {
           return await _dbSet.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await _dbSet.FindAsync(id);
            if(category is null)
            {
                throw new Exception($"Cannot find category with {id} Id");
            }
            return category;
        }
    }
}
