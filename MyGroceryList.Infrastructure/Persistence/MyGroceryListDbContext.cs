using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MyGroceryList.Core.Entities;

namespace MyGroceryList.Infrastructure.Persistence;

public class MyGroceryListDbContext : DbContext 
{
    public MyGroceryListDbContext(DbContextOptions<MyGroceryListDbContext> options) : base(options)
    {
    }
    
    public DbSet<Category> ?Categories { get; set; }
    public DbSet<GroceryItem> ?GroceryItems { get; set; }
    public DbSet<GroceryList> ?GroceryLists { get; set; }
    public DbSet<Store> ?Stores { get; set; }
    public DbSet<User> ?Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyGroceryListDbContext).Assembly);
    }
}