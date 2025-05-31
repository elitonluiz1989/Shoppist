using Shoppist.Domain.Shared.Interfaces;

namespace Shoppist.Domain.Items.Create;

public interface ICreateItemHandler : ICommandHandler<CreateItemCommand, CreateItemResponse?> { }