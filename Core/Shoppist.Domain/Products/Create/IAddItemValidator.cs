using Shoppist.Domain.Base.Results;

namespace Shoppist.Domain.Products.Create;

public interface IAddItemValidator
{
    Result<AddItemResponse?> Execute(AddItemRequest request);
}