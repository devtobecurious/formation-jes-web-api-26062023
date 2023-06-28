using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Models.Games;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Infrastructures.Games
{
    public class AllGameService : IAllGameService
    {
        private readonly IGetOneGameSettingService settingService;

        public AllGameService(IGetOneGameSettingService settingService)
        {
            this.settingService = settingService;
        }

        public List<Game> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}