
using Shoppist.Domain.Base.Results;

namespace Shoppist.Domain.Products.Create;

public interface IAddProductHandler
{
    Task<Result<AddProductResponse?>> Create(AddProductRequest request, CancellationToken cancellationToken);
}