using Microsoft.EntityFrameworkCore;
using MyGroceryList.Core.Entities;
using MyGroceryList.Core.Repositories;

namespace MyGroceryList.Infrastructure.Persistence.repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly MyGroceryListDbContext _context;

    public CategoryRepository(MyGroceryListDbContext context)
    {
        _context = context;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        return await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddAsync(Category category)
    {
        var categoryEntity = _context.Categories.Add(category);
        await _context.SaveChangesAsync();
    }

    public Task SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Category category)
    {
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }
}