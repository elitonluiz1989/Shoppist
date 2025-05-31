using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Items.Create;

public interface ICreateItemValidator
{
    Result<CreateItemResponse?> Execute(CreateItemCommand command);
}