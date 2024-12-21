using Game.DAL.Models;

namespace Game.MVC.ViewModels
{
    public class HomeVM
    {
        public List<Play> Plays { get; set; }
        public List<Category> Categories { get; set; }
        public int? CurrentCategoryId { get; set; }
    }
}
