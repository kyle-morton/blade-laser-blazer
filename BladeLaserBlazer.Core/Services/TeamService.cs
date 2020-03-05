using BladeLaserBlazer.Core.Data;
using BladeLaserBlazer.Core.Data.Models;
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

        public Task<List<Team>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Team> UpdateAsync(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
