using MediatR;
using Microsoft.EntityFrameworkCore;
using MyGroceryList.Application.ViewModels;
using MyGroceryList.Core.Entities;
using MyGroceryList.Core.Repositories;
using MyGroceryList.Infrastructure.Persistence;

namespace MyGroceryList.Application.Queries.GetAllCategories;

public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoryViewModel>>
{
    private readonly ICategoryRepository _categoryRepository;
    
    public GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    
    public async Task<List<CategoryViewModel>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAllAsync();
        var categoryViewModels =  categories
            .Select(c => new CategoryViewModel(c.Id, c.Name))
            .ToList();
        
        return categoryViewModels;
    }
}