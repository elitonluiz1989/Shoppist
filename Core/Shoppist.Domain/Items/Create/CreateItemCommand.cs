using Shoppist.Domain.Shared.Interfaces;

namespace Shoppist.Domain.Items.Create;

public record CreateItemCommand(string Name) : ICommand<CreateItemResponse?>;
