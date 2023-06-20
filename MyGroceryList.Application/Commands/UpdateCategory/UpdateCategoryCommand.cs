using MediatR;

namespace MyGroceryList.Application.Commands.UpdateCategory;

public class UpdateCategoryCommand : IRequest<Unit>
{
    public int Id { get; set; }
    public string? Name { get; set; }

}