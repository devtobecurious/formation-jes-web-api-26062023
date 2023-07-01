using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SdA.Games.Core.Infrastructures.Games;
using SdA.Games.Core.Services.Games;
using System.ComponentModel.DataAnnotations;

namespace SdA.Games.Core.Web.Api.UI.Controllers
{
    public class GamesSetting
    {
        public int NbReborns { get; set; }
        public int NbEnemies { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> logger;

        public GamesController(IHost host, IHostEnvironment environment,
                                IConfiguration configuration,
                                IOptions<GamesSetting> optionGameSetting,
                                ILogger<GamesController> logger)
        {
            this.logger = logger;

            var nbEnemies = configuration["GamesSetting:NbEnemies"];
            var settings = optionGameSetting.Value;

            if (environment.IsDevelopment())
            {

            }

            this.logger.LogInformation("Ah que coucou");
            this.logger.LogError("Ooops I did it again");
        }

        [HttpGet("GetAllGames")]
        //[ApiConventionMethod(typeof(DefaultApiConventions),
        //                     nameof(DefaultApiConventions.Get))]
        //[ProducesResponseType(typeof(Game), StatusCodes.Status200OK)]
        //[HttpGet(Name = "GetAllGames")]
        public IActionResult GetAll([FromServices] IAllGameService service,
            [FromServices] GameDbContext context)
        {
            // context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

            return this.Ok(service.GetAll());
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public IActionResult Post([FromServices] GameDbContext context,
            [FromBody] Test test)
        {
            if (this.ModelState.IsValid)
            {
                context.Games!.Add(new()
                {
                    Id = 0,
                    IsSuccess = false,
                    Titre = test.Name
                });
                context.SaveChanges();

            }

            foreach (var item in ModelState.Values)
            {

            }

            return this.Ok(new { Id = test });
        }
    }

    //public record Test(int Id, string Name);

    public class Test
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string? Name { get; set; }
    }
}
