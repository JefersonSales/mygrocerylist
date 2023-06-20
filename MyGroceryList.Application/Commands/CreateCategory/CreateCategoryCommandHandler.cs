using MediatR;
using MyGroceryList.Core.Entities;
using MyGroceryList.Core.Repositories;
using MyGroceryList.Infrastructure.Persistence;

namespace MyGroceryList.Application.Commands;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
{
    private readonly ICategoryRepository _categoryRepository;
    
    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category(request.Name);
        await _categoryRepository.AddAsync(category);
        return category.Id;
    }
}