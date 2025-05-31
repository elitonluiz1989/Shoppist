namespace Shoppist.Domain.Shared.Entities;

public abstract class Entity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? UpdatedAt { get; private set; }

    public void SetCreatedAt() => CreatedAt = DateTimeOffset.UtcNow;

    public void SetUpdatedAt() => UpdatedAt = DateTimeOffset.UtcNow;
}
