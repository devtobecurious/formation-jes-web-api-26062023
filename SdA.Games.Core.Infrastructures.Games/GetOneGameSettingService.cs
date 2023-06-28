using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Models.Games;

namespace SdA.Games.Core.Infrastructures.Games
{
    public class GetOneGameSettingService : IGetOneGameSettingService
    {
        public GameSetting Get()
        {
            return new(100);
        }
    }
}
