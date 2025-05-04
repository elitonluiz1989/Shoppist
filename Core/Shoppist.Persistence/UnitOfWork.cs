using Shoppist.Domain.Base.Interfaces;
using Shoppist.Persistence.Contexts;

namespace Shoppist.Persistence;

public sealed class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task SaveChangesAsync(CancellationToken cancellationToken) => await context.SaveChangesAsync(cancellationToken);
}
