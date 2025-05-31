using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Shared.Interfaces;

public interface ICommandHandler<in TCommand, TResponse> : IHandler<TCommand, Result<TResponse>>
    where TCommand : IRequest<Result<TResponse>> { }