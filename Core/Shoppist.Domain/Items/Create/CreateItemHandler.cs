using Shoppist.Domain.Items.Shared;
using Shoppist.Domain.Shared.Abstractions;
using Shoppist.Domain.Shared.Interfaces;
using Shoppist.Domain.Shared.Results;

namespace Shoppist.Domain.Items.Create;

public sealed class CreateItemHandler : CommandHandler<Item, CreateItemCommand, CreateItemResponse?>, ICreateItemHandler
{
    private readonly ICreateItemValidator _validator;
    private readonly IItemRepository _repository;

    public CreateItemHandler(IUnitOfWork unitOfWork, ICreateItemValidator validator, IItemRepository repository) : base(unitOfWork)
    {
        _validator = validator;
        _repository = repository;
    }

    protected override Result<CreateItemResponse?> Validate(CreateItemCommand command) => _validator.Execute(command);

    protected override Item MapEntity(CreateItemCommand command) => command.ToItem();

    protected override void Create(Item entity) => _repository.Create(entity);

    protected override Result<CreateItemResponse?> MapResult(Item entity) => entity.ToCreateItemResult();
}
