using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shoppist.Domain.Items.Create;
using Shoppist.Domain.Items.Shared;
using Shoppist.Domain.Shared.Interfaces;
using Shoppist.Persistence.Contexts;
using Shoppist.Persistence.Repositories;

namespace Shoppist.Persistence;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, string? connectionString = null)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<ICreateItemHandler, CreateItemHandler>();
        services.AddScoped<ICreateItemValidator, CreateItemValidator>();
        services.AddScoped<IItemRepository, ItemRepository>();

        AddDbContext(services, connectionString);

        return services;
    }

    private static void AddDbContext(IServiceCollection services, string? connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString)) return;

        SQLitePCL.Batteries.Init();

        services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));
    }
}
