using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Shared.Interfaces;

public interface ICommand<TResponse> : IRequest<Result<TResponse>> {}