using SdA.Games.Core.Web.Api.UI.Controllers;
using SdA.Games.Core.Web.Api.UI.Shared.DIs;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var cs = builder.Configuration["ConnectionStrings:GameDB"];
cs = builder.Configuration.GetConnectionString("GameDB");

//builder.Services.AddProblemDetails();

// builder.Services.AddProblemDetails();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var section = builder.Configuration.GetSection("GamesSetting");
builder.Services.Configure<GamesSetting>(section);

builder.Services.AddCustomDI(builder.Configuration);

var app = builder.Build();

app.Use(async (context, next) =>
{
    var culture = context.Request.Query["culture"];

    if (!string.IsNullOrEmpty(culture))
    {
        var cultureInfo = new CultureInfo(culture!);
        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        Console.WriteLine(DateTime.Today.ToString("dddd dd MMMM yyyy"));
    }

    await next(context);
});

app.Use(async (context, next) =>
{
    var culture = context.Request.Query["test"];
    await next(context);
});

//app.UseMiddleware(typeof(ChangeCultureInfoMiddleWare), args);
//app.UseMiddleware<ChangeCultureInfoMiddleWare>(args);


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//if (app.Environment.IsProduction())
//{
//    app.UseExceptionHandler("/Error");
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Endpoints :)
app.MapGet("/", () =>
{
    return "Hello !!";
});

//app.MapGameEndpoints();

app.Run();
