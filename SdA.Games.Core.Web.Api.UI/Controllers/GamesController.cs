using Microsoft.AspNetCore.Mvc;
using SdA.Games.Core.Services.Games;

namespace SdA.Games.Core.Web.Api.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        [HttpGet("GetALlGames")]
        //[HttpGet(Name = "GetAllGames")]
        public IActionResult GetAll([FromServices] IAllGameService service)
        {
            return this.Ok(service.GetAll());
        }
    }
}
