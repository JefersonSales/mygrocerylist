using MediatR;

namespace MyGroceryList.Application.Commands.DeleteCategory;

public class DeleteCategoryCommand : IRequest<Unit>
{
    public DeleteCategoryCommand(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}