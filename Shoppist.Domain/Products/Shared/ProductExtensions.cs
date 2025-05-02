using Shoppist.Domain.Products.Create;

namespace Shoppist.Domain.Products.Shared;

public static class ProductExtensions
{
    public static Product ToProduct(this AddProductRequest request)
    {
        return new Product
        {
            Name = request.Name,
            Quantity = request.Quantity,
            Price = request.Price
        };
    }

    public static AddProductResponse ToAddProductResponse(this Product product)
    {
        return new AddProductResponse(
            product.Id,
            product.Name,
            product.Quantity,
            product.Price,
            product.CreatedAt,
            product.UpdatedAt
        );
    }
}
