using Microsoft.EntityFrameworkCore;
using SdA.Games.Core.Applications.Games;
using SdA.Games.Core.Models.Games;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Infrastructures.Games
{
    public class AllGameService : IAllGameService
    {
        private readonly IGetOneGameSettingService settingService;
        private readonly GameDbContext gameContext;

        public AllGameService(IGetOneGameSettingService settingService, GameDbContext gameContext)
        {
            this.settingService = settingService;
            this.gameContext = gameContext;
        }

        public List<Game>? GetAll()
        {
            throw new NotImplementedException("Ouch, j'ai zappé de finir le code");
            return this.gameContext.Games?.AsNoTracking().ToList();
        }
    }
}