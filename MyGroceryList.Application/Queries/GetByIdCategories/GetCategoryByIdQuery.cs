using MediatR;
using MyGroceryList.Application.ViewModels;

namespace MyGroceryList.Application.Queries.GetByIdCategories;

public class GetCategoryByIdQuery : IRequest<CategoryDetailsViewModel>
{
    public GetCategoryByIdQuery(int id)
    {
        Id = id;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> GroceryItem { get; private set; }
}
