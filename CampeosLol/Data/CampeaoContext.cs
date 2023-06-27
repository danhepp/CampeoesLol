using CampeosLol.Models;
using Microsoft.EntityFrameworkCore;

namespace CampeoesLol.Data
{
    public class CampeaoContext : DbContext
    {
        public DbSet<Campeao> Campeoes { get; set; }

        public CampeaoContext(DbContextOptions<CampeaoContext> opts) : base(opts)
        {
        }
    }
}
