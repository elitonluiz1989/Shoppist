namespace Shoppist.Domain.Products.Create;

public record AddProductRequest(string Name, short Quantity, decimal Price);
