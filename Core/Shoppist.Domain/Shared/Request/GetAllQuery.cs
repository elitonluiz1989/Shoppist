using System.Linq.Expressions;
using Shoppist.Domain.Shared.Entities;

namespace Shoppist.Domain.Shared.Request;

public abstract record GetAllQuery<TEntity, TProjection>(Expression<Func<TEntity, TProjection>> Projection)
    where TEntity : Entity
    where TProjection : notnull
{
    public Expression<Func<TEntity, bool>>? Filter { get; set; }
    public Func<IQueryable<TEntity>, IQueryable<TEntity>>? OrderBy { get; set; }
    public PaginationRequest? Pagination { get; set; }
}
