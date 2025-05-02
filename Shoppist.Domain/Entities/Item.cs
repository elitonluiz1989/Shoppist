using Shoppist.Domain.Interfaces;

namespace Shoppist.Domain.Entities;

public sealed class Item : Entity, IRecordControlEntity
{
    public string Title { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}
