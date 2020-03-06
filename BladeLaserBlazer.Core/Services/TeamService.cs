using BladeLaserBlazer.Core.Data;
using BladeLaserBlazer.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BladeLaserBlazer.Core.Services
{
    public interface ITeamService
    {
        Task<List<Team>> GetAsync();
        Task<Team> GetAsync(int id);
        Task<Team> CreateAsync(Team team);
        Task<Team> UpdateAsync(Team team);
    }

    public class TeamService : ServiceBase, ITeamService
    {

        public TeamService(BLBDbContext context) : base(context)
        {
        }

        public Task<Team> CreateAsync(Team team)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Team>> GetAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetAsync(int id)
        {
            return await _context.Teams.SingleOrDefaultAsync(t => t.Id == id);
        }

        public Task<Team> UpdateAsync(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
