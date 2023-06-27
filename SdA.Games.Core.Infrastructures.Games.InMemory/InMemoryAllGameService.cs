using SdA.Games.Core.Models.Games;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Infrastructures.Games.InMemory
{
    public class InMemoryAllGameService : IAllGameService
    {
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