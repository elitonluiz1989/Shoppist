using Shoppist.Domain.Base.Entities;

namespace Shoppist.Domain.Products.Entities;

public sealed class Product : Entity
{
    public string Title { get; set; } = default!;
    public short Quantity { get; set; }
    public decimal Price { get; set; }
}
