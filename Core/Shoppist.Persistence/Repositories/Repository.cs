using Microsoft.EntityFrameworkCore;
using Shoppist.Persistence.Contexts;
using System.Linq.Expressions;
using Shoppist.Domain.Shared.Entities;
using Shoppist.Domain.Shared.Interfaces;
using Shoppist.Domain.Shared.Request;

namespace Shoppist.Persistence.Repositories
{
    public class Repository<TEntity>(AppDbContext context) : IRepository<TEntity> where TEntity : Entity
    {
        public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await GetDbSet().ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<TProjection>> GetAllAsync<TProjection>(GetAllQuery<TEntity, TProjection> request, CancellationToken cancellationToken)
            where TProjection : notnull
        {
            IQueryable<TEntity> query = GetDbSet();

            if (request.Filter is not null)
                query = query.Where(request.Filter);

            if (request.OrderBy is not null)
                query = request.OrderBy.Invoke(query);

            if (request.Pagination is not null)
                query = query.Skip(request.Pagination.Skip).Take(request.Pagination.Size);

            IEnumerable<TProjection> results = await query.Select(request.Projection).ToListAsync(cancellationToken);

            return results;
        }

        public async Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await GetDbSet().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
        }

        public async Task<TProjection?> GetAsync<TProjection>(Guid id, Expression<Func<TEntity, TProjection>> projection, CancellationToken cancellationToken)
            where TProjection : notnull
        {
            return await GetDbSet().Where(p => p.Id.Equals(id)).Select(projection).FirstOrDefaultAsync(cancellationToken);
        }

        public virtual void Create(TEntity entity)
        {
            GetDbSet().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            GetDbSet().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            GetDbSet().Remove(entity);
        }

        private DbSet<TEntity> GetDbSet()
        {
            return context.Set<TEntity>();
        }
    }
}
