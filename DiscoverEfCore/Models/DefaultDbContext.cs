using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore.Infrastructure;
using System.Diagnostics.CodeAnalysis;

namespace DiscoverEfCore.Models
{
    public static class DefaultContextExtensions
    {
        public static IServiceCollection AddDefaultDbContext(this IServiceCollection services)
        {
            var configTimeOutAndCoOfOracle = (OracleDbContextOptionsBuilder optionsO) =>
            {
                optionsO.CommandTimeout(1000);
            };

            var configCSAndTimeout = (DbContextOptionsBuilder options) =>
            {
                var cs = "Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;Integrated Security=no;";
                options.UseOracle(cs, configTimeOutAndCoOfOracle);
            };

            services.AddDbContext<DefaultDbContext>(configCSAndTimeout);
            return services;
        }
    }

    public class DefaultDbContext : DbContext
    {


        public DefaultDbContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultDbContext()
        {
        }
        #region Vers les tables

        [MaybeNull]
        public DbSet<Train> Trains { get; set; }
        #endregion
    }
}
