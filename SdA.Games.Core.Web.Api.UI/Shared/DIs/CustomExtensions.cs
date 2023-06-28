using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Infrastructures.Games;
using SdA.Games.Core.Infrastructures.Games.InMemory;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Web.Api.UI.Shared.DIs
{
    public static class CustomExtensions
    {
        #region Public methods
        public static IServiceCollection AddCustomDI(this IServiceCollection services)
        {
            services.AddSingleton<IGetOneGameSettingService, GetOneGameSettingService>();

#if DEBUG
            services.AddScoped<IAllGameService, InMemoryAllGameService>();
#else
services.AddScoped<IAllGameService, AllGameService>();
services.AddScoped<IAllGameService, AllGameService>();
#endif
            return services;
        }
        #endregion
    }
}
