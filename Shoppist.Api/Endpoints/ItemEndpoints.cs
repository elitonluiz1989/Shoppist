using Microsoft.AspNetCore.Mvc;
using Shoppist.Api.Extensions;
using Shoppist.Domain.Items.Create;
using Shoppist.Domain.Shared.Results;

namespace Shoppist.Api.Endpoints;

public static class ItemEndpoints
{
    public static void MapItemEndpoints(this WebApplication app)
    {
        app.MapPost(
            "/items",
            async ([FromBody] CreateItemCommand request, [FromServices] ICreateItemHandler handler, CancellationToken token) =>
            {
                Result<CreateItemResponse?> result = await handler.HandleAsync(request, token);

                return result.ToApiResult();
            }
        );
    }
}