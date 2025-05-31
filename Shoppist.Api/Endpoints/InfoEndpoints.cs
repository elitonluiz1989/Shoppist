using System.Reflection;

namespace Shoppist.Api.Endpoints;

public static class InfoEndpoints
{
    public static void MapInfoEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", GetApiInfo).Produces(200).ProducesProblem(500);
        app.MapGet("/info", GetApiInfo).Produces(200).ProducesProblem(500);
    }

    private static IResult GetApiInfo()
    {
        var apiInfo = new
        {
            Assembly.GetExecutingAssembly().GetName().Version,
            CurrentDateTime = DateTime.Now
        };
        return Results.Ok(apiInfo);
    }
}