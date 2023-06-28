using Microsoft.EntityFrameworkCore;
using SdA.Games.Core.Infrastructures.Games.Configs;
using SdA.Games.Core.Models.Games;

namespace SdA.Games.Core.Infrastructures.Games
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions options) : base(options)
        {
        }

        protected GameDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Game>().HasKey(t => t.Id);
            //modelBuilder.Entity<Game>().ToTable("Game");

            modelBuilder.ApplyConfiguration(new GameEntityTypeConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public DbSet<Game>? Games { get; set; }
    }
}
