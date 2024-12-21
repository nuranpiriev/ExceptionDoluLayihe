using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DAL.Models
{
    public class Category:BaseAuditable
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public ICollection<Play> Plays { get; set; }
    }
}
