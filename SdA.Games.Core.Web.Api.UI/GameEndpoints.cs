using SdA.Games.Core.Models.Games;
namespace SdA.Games.Core.Web.Api.UI;

public static class GameEndpoints
{
    public static void MapGameEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Game", () =>
        {
            return new [] { new Game() };
        })
        .WithName("GetAllGames")
        .Produces<Game[]>(StatusCodes.Status200OK);

        routes.MapGet("/api/Game/{id}", (int id) =>
        {
            //return new Game { ID = id };
        })
        .WithName("GetGameById")
        .Produces<Game>(StatusCodes.Status200OK);

        routes.MapPut("/api/Game/{id}", (int id, Game input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateGame")
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Game/", (Game model) =>
        {
            //return Results.Created($"/api/Games/{model.ID}", model);
        })
        .WithName("CreateGame")
        .Produces<Game>(StatusCodes.Status201Created);

        routes.MapDelete("/api/Game/{id}", (int id) =>
        {
            //return Results.Ok(new Game { ID = id });
        })
        .WithName("DeleteGame")
        .Produces<Game>(StatusCodes.Status200OK);
    }
}
