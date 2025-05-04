namespace Shoppist.Domain.Products.Create;

public record AddItemResponse(
    Guid Id,
    string Name,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
);
