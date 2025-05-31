using Shoppist.Domain.Items.Shared;
using Shoppist.Persistence.Contexts;

namespace Shoppist.Persistence.Repositories;

public sealed class ItemRepository(AppDbContext context) : Repository<Item>(context), IItemRepository { }
