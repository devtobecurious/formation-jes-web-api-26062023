using Microsoft.EntityFrameworkCore;
using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Infrastructures.Games;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Web.Api.UI.Shared.DIs
{
    public static class CustomExtensions
    {
        #region Public methods
        public static IServiceCollection AddCustomDI(this IServiceCollection services,
                                                     IConfiguration configuration)
        {
            services.AddSingleton<IGetOneGameSettingService, GetOneGameSettingService>();

            services.AddScoped<IAllGameService, AllGameService>();

            services.AddDbContext<GameDbContext>(options =>
            {
                options.UseInMemoryDatabase("bla", conf =>
                {
                    conf.EnableNullChecks(true);
                });
                //options.UseOracle(configuration.GetConnectionString("GameDB"), b => b.MigrationsAssembly("SdA.Games.Core.Web.Api.UI"));
            });

            return services;
        }
        #endregion
    }
}
