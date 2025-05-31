namespace Shoppist.Domain.Items.Create;

public record CreateItemResponse(
    Guid Id,
    string Name,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
);
