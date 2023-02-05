using Microsoft.EntityFrameworkCore;
using Skyline.BitrateCalculation.API.Models;

namespace Skyline.BitrateCalculation.API.Database
{
    public class BirateCalculationDbContext : DbContext
    {
        public BirateCalculationDbContext(DbContextOptions<BirateCalculationDbContext> options) : base(options)
        {

        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<NIC> NICs { get; set; }

    }
}
