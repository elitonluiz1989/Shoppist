using Shoppist.Domain.Products.Entities;
using Shoppist.Domain.Products.Interfaces;
using Shoppist.Persistence.Contexts;

namespace Shoppist.Persistence.Repositories;

public sealed class ProductRepository(AppDbContext context) : Repository<Product>(context), IProductRepository { }
