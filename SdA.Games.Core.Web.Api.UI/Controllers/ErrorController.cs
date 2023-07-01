using Microsoft.AspNetCore.Mvc;

namespace SdA.Games.Core.Web.Api.UI.Controllers
{
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult HandleError() => Problem();
    }
}
