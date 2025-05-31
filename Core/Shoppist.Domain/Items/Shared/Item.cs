using Shoppist.Domain.Shared.Entities;

namespace Shoppist.Domain.Items.Shared;

public sealed class Item : Entity
{
    public string Name { get; set; } = null!;
}
