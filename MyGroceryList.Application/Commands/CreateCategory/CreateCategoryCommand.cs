using MediatR;

namespace MyGroceryList.Application.Commands;

public class CreateCategoryCommand : IRequest<int>
{
    public string? Name { get; set; }
}