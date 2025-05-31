using Shoppist.Domain.Shared.Entities;
using Shoppist.Domain.Shared.Interfaces;
using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Shared.Abstractions;

public abstract class CommandHandler<TEntity, TCommand, TResponse> : ICommandHandler<TCommand, TResponse>
    where TEntity : Entity
    where TCommand : ICommand<TResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    protected CommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<TResponse>> HandleAsync(TCommand command, CancellationToken cancellationToken)
    {
        Result<TResponse> result = Validate(command);

        if (result.IsFailure)
            return result;

        TEntity entity = MapEntity(command);

        entity.SetCreatedAt();

        Create(entity);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return MapResult(entity);
    }

    protected abstract Result<TResponse> Validate(TCommand command);

    protected abstract TEntity MapEntity(TCommand command);

    protected abstract void Create(TEntity entity);
    
    protected abstract Result<TResponse> MapResult(TEntity entity);
}