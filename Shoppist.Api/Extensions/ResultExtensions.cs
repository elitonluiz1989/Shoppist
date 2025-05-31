using Shoppist.Domain.Shared.Results;

namespace Shoppist.Api.Extensions;

public static class ResultExtensions
{
    public static IResult ToApiResult<TValue>(this Result<TValue> result)
    {
        return result.IsSuccess ? Results.Ok(result.Value) : Results.BadRequest(result.Errors);
    }
}