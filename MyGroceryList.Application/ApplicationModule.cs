using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyGroceryList.Application.Commands;

namespace MyGroceryList.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddMediatR(typeof(CreateCategoryCommandHandler));
        return services;
    }
}