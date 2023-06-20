using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyGroceryList.Core.Repositories;
using MyGroceryList.Infrastructure.Persistence;
using MyGroceryList.Infrastructure.Persistence.repositories;

namespace MyGroceryList.Infrastructure;

public static class InfrastructureModule
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
        services.AddPersistence(configuration);
		services.AddRepositories();
        return services;
	}

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MyGroceryListDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("MyGroceryListDbConextion")));
        // services.AddDbContext<DevFreelaDbContext>(options => options.UseInMemoryDatabase("DefaultConnection"));

        return services;
    }
    
    public static IServiceCollection AddRepositories(this IServiceCollection services)
	{
		services.AddScoped<ICategoryRepository, CategoryRepository>();
		return services;
	}

}