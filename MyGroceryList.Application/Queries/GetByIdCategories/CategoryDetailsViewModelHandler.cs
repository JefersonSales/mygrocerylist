using MediatR;
using MyGroceryList.Application.ViewModels;
using MyGroceryList.Core.Repositories;

namespace MyGroceryList.Application.Queries.GetByIdCategories;

public class CategoryDetailsViewModelHandler : IRequestHandler<GetCategoryByIdQuery, CategoryDetailsViewModel>
{
    public readonly ICategoryRepository _categoryRepository;
    
    public CategoryDetailsViewModelHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    public async Task<CategoryDetailsViewModel> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
       var category = await _categoryRepository.GetByIdAsync(request.Id);
       
         if (category == null) throw new Exception("Category not found");
         
         return await Task.FromResult(new CategoryDetailsViewModel(category.Id, category.Name, category.GroceryItem));
    }
}