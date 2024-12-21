using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DAL.Models
{
    public class Play:BaseAuditable
    {
        public string Name { get; set; }  
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
