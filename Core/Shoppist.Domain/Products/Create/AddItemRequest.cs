namespace Shoppist.Domain.Products.Create;

public record AddItemRequest(string Name, short Quantity, decimal Price);
