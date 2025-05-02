using Shoppist.Domain.Base.Entities;

namespace Shoppist.Domain.Products.Shared;

public sealed class Product : Entity
{
    public string Name { get; set; } = default!;
    public short Quantity { get; set; }
    public decimal Price { get; set; }
}
