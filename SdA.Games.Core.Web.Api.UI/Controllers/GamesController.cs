using Microsoft.AspNetCore.Mvc;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Web.Api.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GamesController : ControllerBase
    {
        public GamesController(IHost host, IHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {

            }
        }

        [HttpGet("GetAllGames")]
        //[ApiConventionMethod(typeof(DefaultApiConventions),
        //                     nameof(DefaultApiConventions.Get))]
        //[ProducesResponseType(typeof(Game), StatusCodes.Status200OK)]
        //[HttpGet(Name = "GetAllGames")]
        public IActionResult GetAll([FromServices] IAllGameService service)
        {
            return this.Ok(service.GetAll());
        }
    }
}
