using Shoppist.Domain.Products.Shared;
using Shoppist.Persistence.Contexts;

namespace Shoppist.Persistence.Repositories;

public sealed class ItemRepository(AppDbContext context) : Repository<Item>(context), IItemRepository { }
