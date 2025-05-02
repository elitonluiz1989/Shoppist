using FluentValidation;
using Shoppist.Domain.Base.Results;
using System.Collections.Immutable;

namespace Shoppist.Domain.Products.Create;

public sealed class AddProductValidator : AbstractValidator<AddProductRequest>, IAddProductValidator
{
    public AddProductValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Quantity).GreaterThan(default(short));
        RuleFor(x => x.Price).GreaterThan(default(decimal));
    }

    public Result<AddProductResponse?> Execute(AddProductRequest request)
    {
        if (request is null)
            return Result<AddProductResponse?>.CreateFailure(ValidationErrorResults.RequestIsNull);

        var results = Validate(request);

        if (results.IsValid)
            return Result<AddProductResponse?>.CreateSuccess();

        ImmutableArray<ErrorResult> errors = results.Errors
            .Select(p => new ErrorResult(p.ErrorCode, p.ErrorMessage))
            .ToImmutableArray();

        return Result<AddProductResponse?>.CreateFailure(errors);
    }
}
