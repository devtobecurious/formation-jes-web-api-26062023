using Microsoft.EntityFrameworkCore;
using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Infrastructures.Games;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Web.Api.UI.Shared.DIs
{
    public static class CustomExtensions
    {
        #region Public methods
        public static IServiceCollection AddCustomDI(this IServiceCollection services)
        {
            services.AddSingleton<IGetOneGameSettingService, GetOneGameSettingService>();

            services.AddScoped<IAllGameService, AllGameService>();

            services.AddDbContext<GameDbContext>(options =>
            {
                options.UseOracle("test", b => b.MigrationsAssembly("SdA.Games.Core.Web.Api.UI"));
            });

            return services;
        }
        #endregion
    }
}
