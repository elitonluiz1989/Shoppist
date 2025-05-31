using System.Linq.Expressions;
using Shoppist.Domain.Shared.Entities;
using Shoppist.Domain.Shared.Request;

namespace Shoppist.Domain.Shared.Interfaces;

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<IEnumerable<TProjection>> GetAllAsync<TProjection>(GetAllQuery<TEntity, TProjection> query, CancellationToken cancellationToken) where TProjection : notnull;
    Task<TEntity?> GetAsync(Guid Id, CancellationToken cancellationToken);
    Task<TProjection?> GetAsync<TProjection>(Guid Id, Expression<Func<TEntity, TProjection>> Projection, CancellationToken cancellationToken) where TProjection : notnull;
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
