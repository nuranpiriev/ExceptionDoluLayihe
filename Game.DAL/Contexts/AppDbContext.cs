using Game.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DAL.Contexts
{
  

    public class AppDbContext:DbContext
    {
        public DbSet<Play> Plays { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions opt) : base(opt) { }
    }
}
