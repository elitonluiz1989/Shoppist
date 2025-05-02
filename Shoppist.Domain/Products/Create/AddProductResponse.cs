namespace Shoppist.Domain.Products.Create;

public record AddProductResponse(
    Guid Id,
    string Name,
    int Quantity,
    decimal Price,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
);
