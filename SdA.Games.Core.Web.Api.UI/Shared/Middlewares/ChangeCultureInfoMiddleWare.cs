namespace SdA.Games.Core.Web.Api.UI.Shared.Middlewares
{
    public class ChangeCultureInfoMiddleWare
    {
        private readonly RequestDelegate next;

        public ChangeCultureInfoMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            await this.next(context);
        }
    }
}
