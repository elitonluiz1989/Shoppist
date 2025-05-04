
using Shoppist.Domain.Base.Results;

namespace Shoppist.Domain.Products.Create;

public interface IAddItemHandler
{
    Task<Result<AddItemResponse?>> Create(AddItemRequest request, CancellationToken cancellationToken);
}