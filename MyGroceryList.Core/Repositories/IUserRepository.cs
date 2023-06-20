using MyGroceryList.Core.Entities;

namespace MyGroceryList.Core.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User> GetByIdAsync(int id);
    Task AddAsync(User user);
    Task SaveChangesAsync();
    Task DeleteAsync(User user);
}