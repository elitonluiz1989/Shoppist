using Shoppist.Domain.Products.Create;

namespace Shoppist.Domain.Products.Shared;

public static class ItemExtensions
{
    public static Item ToItem(this AddItemRequest request)
    {
        return new Item
        {
            Name = request.Name
        };
    }

    public static AddItemResponse ToAddItemResponse(this Item item)
    {
        return new AddItemResponse(
            item.Id,
            item.Name,
            item.CreatedAt,
            item.UpdatedAt
        );
    }
}
