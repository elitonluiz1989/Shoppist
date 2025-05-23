﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shoppist.Domain.Base.Interfaces;
using Shoppist.Domain.Products.Create;
using Shoppist.Domain.Products.Shared;
using Shoppist.Persistence.Contexts;
using Shoppist.Persistence.Repositories;

namespace Shoppist.Persistence;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAddItemHandler, AddItemHandler>();
        services.AddScoped<IAddItemValidator, AddItemValidator>();
        services.AddScoped<IItemRepository, ItemRepository>();

        return services;
    }

    public static IServiceCollection AddPersistenceSqliteDbContext(this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<AppDbContext>(p => p.UseSqlite(connectionString));

        return services;
    }
}
