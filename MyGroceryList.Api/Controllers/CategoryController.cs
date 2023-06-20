using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyGroceryList.Application.Commands;
using MyGroceryList.Application.Commands.DeleteCategory;
using MyGroceryList.Application.Commands.UpdateCategory;
using MyGroceryList.Application.Queries.GetAllCategories;
using MyGroceryList.Application.Queries.GetByIdCategories;
using MyGroceryList.Core.Dtos;

namespace MyGroceryList.Api.Controllers;

[Route("api/categories")]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _mediator.Send(new GetAllCategoriesQuery());
        return Ok(categories);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await _mediator.Send(new GetCategoryByIdQuery(id));
        return Ok(category);
    }
    
    
    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand command)
    {
        var id = await _mediator.Send(command);
        return Ok(id);
    } 
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(int id, [FromBody] UpdateCategoryDto command)
    {
        await _mediator.Send(command);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        await _mediator.Send(new DeleteCategoryCommand(id));
        return Ok();
    }
}