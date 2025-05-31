using System.Collections.Immutable;
using FluentValidation;
using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Shared.Abstractions;

public abstract class Validator<TRequest, TResponse> : AbstractValidator<TRequest>
{
    public Result<TResponse?> Execute(TRequest? request)
    {
        if (request is null)
            return Result<TResponse?>.CreateFailure(ValidationErrorResults.RequestIsNull);

        var results = Validate(request);

        if (results.IsValid)
            return Result<TResponse?>.CreateSuccess();

        ImmutableArray<ErrorResult> errors = results.Errors
            .Select(p => new ErrorResult(p.ErrorCode, p.ErrorMessage))
            .ToImmutableArray();

        return Result<TResponse?>.CreateFailure(errors);
    }
}
