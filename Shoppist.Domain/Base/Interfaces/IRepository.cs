using Shoppist.Domain.Base.Entities;
using Shoppist.Domain.Base.Request;
using System.Linq.Expressions;

namespace Shoppist.Domain.Base.Interfaces;

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<IEnumerable<TProjection>> GetAllAsync<TProjection>(GetAllRequest<TEntity, TProjection> request, CancellationToken cancellationToken) where TProjection : notnull;
    Task<TEntity?> GetAsync(Guid Id, CancellationToken cancellationToken);
    Task<TProjection?> GetAsync<TProjection>(Guid Id, Expression<Func<TEntity, TProjection>> Projection, CancellationToken cancellationToken) where TProjection : notnull;
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
