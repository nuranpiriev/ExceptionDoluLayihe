using Game.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BL.Service.Abstractions
{
    public interface IPlayService
    {
        Task<Play> GetPlayByIdAsync(int id);
        Task<IEnumerable<Play>> GetAllPlaysAsync();
        Task AddPlayAsync(Play play);
        Task EditPlayAsync(int id,Play play);
        Task DeletePlayAsync(int id);
    }
}
