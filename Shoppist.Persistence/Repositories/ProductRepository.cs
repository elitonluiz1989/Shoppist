using Shoppist.Domain.Products.Shared;
using Shoppist.Persistence.Contexts;

namespace Shoppist.Persistence.Repositories;

public sealed class ProductRepository(AppDbContext context) : Repository<Product>(context), IProductRepository { }
