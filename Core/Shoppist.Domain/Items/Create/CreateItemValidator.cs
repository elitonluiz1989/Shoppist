using FluentValidation;
using Shoppist.Domain.Shared.Abstractions;

namespace Shoppist.Domain.Items.Create;

public sealed class CreateItemValidator : Validator<CreateItemCommand, CreateItemResponse>, ICreateItemValidator
{
    public CreateItemValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
    }
}
