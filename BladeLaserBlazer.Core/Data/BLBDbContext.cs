using BladeLaserBlazer.Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BladeLaserBlazer.Core.Data
{
    public class BLBDbContext : DbContext
    {

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Manager> Manager { get; set; }

        public BLBDbContext(DbContextOptions<BLBDbContext> options) : base(options)
        {
        }


    }
}
