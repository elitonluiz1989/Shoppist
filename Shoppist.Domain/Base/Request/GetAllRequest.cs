using Shoppist.Domain.Base.Entities;
using System.Linq.Expressions;

namespace Shoppist.Domain.Base.Request;

public record GetAllRequest<TEntity, TProjection> where TEntity : Entity where TProjection : notnull
{
    public Expression<Func<TEntity, TProjection>> Projection { get; init; }
    public Expression<Func<TEntity, bool>>? Filter { get; set; }
    public Func<IQueryable<TEntity>, IQueryable<TEntity>>? OrderBy { get; set; }
    public PaginationRequest? Pagination { get; set; }

    public GetAllRequest(Expression<Func<TEntity, TProjection>> projection)
    {
        Projection = projection;
    }
}
