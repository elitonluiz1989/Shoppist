using Shoppist.Domain.Base.Interfaces;
using Shoppist.Domain.Base.Results;
using Shoppist.Domain.Products.Shared;

namespace Shoppist.Domain.Products.Create;

public sealed class AddItemHandler(IUnitOfWork unitOfWork, IAddItemValidator validator, IItemRepository repository) : IAddItemHandler
{
    public async Task<Result<AddItemResponse?>> Create(AddItemRequest request, CancellationToken cancellationToken)
    {
        Result<AddItemResponse?> result = validator.Execute(request);

        if (result.IsFailure)
            return result;

        Item item = request.ToItem();

        item.SetCreatedAt();

        repository.Create(item);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        AddItemResponse response = item.ToAddItemResponse();

        return Result<AddItemResponse?>.CreateSuccess(response);
    }
}
