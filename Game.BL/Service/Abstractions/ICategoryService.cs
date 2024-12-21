using Game.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL.Service.Abstractions
{
    public interface ICategoryService
    {
        Task<ICollection<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(int id);
        Task EditCategoryAsync(int id,Category category);
    }
}
