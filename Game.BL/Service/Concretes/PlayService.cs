using Game.BL.Service.Abstractions;
using Game.DAL.Contexts;
using Game.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL.Service.Concretes
{
    public class PlayService : IPlayService
    {
        readonly AppDbContext _context;
        readonly DbSet<Play> _dbSet;
        public PlayService(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Play>();
        }

        public async Task AddPlayAsync(Play play)
        {
            await _dbSet.AddAsync(play);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlayAsync(int id)
        {
            var play=await _dbSet.FindAsync(id);
            if (play is null)
            {
                throw new Exception($"Cannot find entity with {id} id");
            }
            _dbSet.Remove(play);
            await _context.SaveChangesAsync();
            
        }

        public async Task EditPlayAsync(int id, Play play)
        {
            var existPlay = await _dbSet.FindAsync(id);
            _context.Entry(existPlay).CurrentValues.SetValues(play);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Play>> GetAllPlaysAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Play> GetPlayByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if(entity is null)
            {
                throw new Exception($"Cannot find entity with {id} id");
            }
            return entity;
            
        }
    }
}
