using Shoppist.Domain.Base.Interfaces;
using Shoppist.Domain.Base.Results;
using Shoppist.Domain.Products.Shared;

namespace Shoppist.Domain.Products.Create;

public sealed class AddProductHandler(IUnitOfWork unitOfWork, IAddProductValidator validator, IProductRepository repository) : IAddProductHandler
{
    public async Task<Result<AddProductResponse?>> Create(AddProductRequest request, CancellationToken cancellationToken)
    {
        Result<AddProductResponse?> result = validator.Execute(request);

        if (result.IsFailure)
            return result;

        Product product = request.ToProduct();

        product.SetCreatedAt();

        repository.Create(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        AddProductResponse response = product.ToAddProductResponse();

        return Result<AddProductResponse?>.CreateSuccess(response);
    }
}
