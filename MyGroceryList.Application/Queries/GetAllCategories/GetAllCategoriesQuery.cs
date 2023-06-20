using MediatR;
using MyGroceryList.Application.ViewModels;

namespace MyGroceryList.Application.Queries.GetAllCategories;

public class GetAllCategoriesQuery : IRequest<List<CategoryViewModel>>
{
    
}