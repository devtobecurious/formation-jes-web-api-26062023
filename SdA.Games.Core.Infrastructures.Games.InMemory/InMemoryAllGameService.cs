using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Models.Games;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Infrastructures.Games.InMemory
{
    public class InMemoryAllGameService : IAllGameService
    {
        private readonly IGetOneGameSettingService settingService;

        public InMemoryAllGameService(IGetOneGameSettingService settingService)
        {
            this.settingService = settingService;
        }
        public List<Game> GetAll()
        {
            return new()
            {
                new(),
                new()
            };
        }
    }
}