using Shoppist.Domain.Items.Create;
using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Items.Shared;

public static class ItemExtensions
{
    public static Item ToItem(this CreateItemCommand command)
    {
        return new Item
        {
            Name = command.Name
        };
    }

    public static Result<CreateItemResponse?> ToCreateItemResult(this Item item)
    {
        var response = new CreateItemResponse(
            item.Id,
            item.Name,
            item.CreatedAt,
            item.UpdatedAt
        );
        
        return Result<CreateItemResponse?>.CreateSuccess(response);
    }
}
