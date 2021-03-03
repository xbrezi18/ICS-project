using Microsoft.EntityFrameworkCore;
using FestivalsOverview.DAL.Entities;

namespace FestivalsOverview.DAL
{
    public class FestivalsOverviewDbContext : DbContext
    {
        public FestivalsOverviewDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        public DbSet<BandEntity> Bands { get; set; } = null!;
        public DbSet<StageEntity> Stages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<BandEntity>();

           // modelBuilder.Entity<StageEntity>();



            base.OnModelCreating(modelBuilder);
        }
    }
}
