using MyGroceryList.Core.Entities;

namespace MyGroceryList.Core.Repositories;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllAsync();
    Task<Category> GetByIdAsync(int id);
    Task AddAsync(Category category);
    
    Task SaveChangesAsync();
    
    Task DeleteAsync(Category category);
}