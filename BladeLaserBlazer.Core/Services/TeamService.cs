using BladeLaserBlazer.Core.Data;
using BladeLaserBlazer.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BladeLaserBlazer.Core.Services
{
    public interface ITeamService
    {
        Task<List<Team>> GetAsync(int count, int offset);
        Task<Team> GetAsync(int id);
        Task<Team> CreateAsync(Team team);
        Task<Team> UpdateAsync(Team team);
    }

    public class TeamService : ServiceBase, ITeamService
    {

        public TeamService(BLBDbContext context) : base(context) { }

        public async Task<Team> CreateAsync(Team team)
        {
            await _context.AddAsync(team);
            await _context.SaveChangesAsync();

            return team;
        }

        public async Task<List<Team>> GetAsync(int count, int offset)
        {
            return await _context.Teams
                .Skip(offset)
                .Take(count)
                .ToListAsync();
        }

        public async Task<Team> GetAsync(int id)
        {
            return await _context.Teams.SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Team> UpdateAsync(Team team)
        {
            var existingTeam = await _context.Teams.SingleOrDefaultAsync(t => t.Id == team.Id);
            if (existingTeam == null)
            {
                return null;
            }

            existingTeam.NickName = team.NickName;
            existingTeam.Location = team.Location;

            await _context.SaveChangesAsync();

            return team;
        }
    }
}
