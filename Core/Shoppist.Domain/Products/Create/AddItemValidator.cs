using FluentValidation;
using Shoppist.Domain.Base.Results;
using System.Collections.Immutable;

namespace Shoppist.Domain.Products.Create;

public sealed class AddItemValidator : AbstractValidator<AddItemRequest>, IAddItemValidator
{
    public AddItemValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Quantity).GreaterThan(default(short));
        RuleFor(x => x.Price).GreaterThan(default(decimal));
    }

    public Result<AddItemResponse?> Execute(AddItemRequest? request)
    {
        if (request is null)
            return Result<AddItemResponse?>.CreateFailure(ValidationErrorResults.RequestIsNull);

        var results = Validate(request);

        if (results.IsValid)
            return Result<AddItemResponse?>.CreateSuccess();

        ImmutableArray<ErrorResult> errors = results.Errors
            .Select(p => new ErrorResult(p.ErrorCode, p.ErrorMessage))
            .ToImmutableArray();

        return Result<AddItemResponse?>.CreateFailure(errors);
    }
}
