using MediatR;
using MyGroceryList.Core.Repositories;

namespace MyGroceryList.Application.Commands.DeleteCategory;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Unit>
{
    private readonly ICategoryRepository _categoryRepository;
    
    public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    public Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _categoryRepository.GetByIdAsync(request.Id);
        _categoryRepository.DeleteAsync(category.Result);
        return Unit.Task;
    }
}