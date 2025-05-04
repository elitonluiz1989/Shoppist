using Shoppist.Domain.Base.Entities;

namespace Shoppist.Domain.Products.Shared;

public sealed class Item : Entity
{
    public string Name { get; set; } = default!;
}
