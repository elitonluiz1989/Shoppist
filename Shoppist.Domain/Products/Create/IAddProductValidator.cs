using Shoppist.Domain.Base.Results;

namespace Shoppist.Domain.Products.Create;

public interface IAddProductValidator
{
    Result<AddProductResponse?> Execute(AddProductRequest request);
}