using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shoppist.Persistence.Contexts;

namespace Shoppist.Persistence;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistenceSqliteDbContext(this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<AppDbContext>(p => p.UseSqlite(connectionString));

        return services;
    }
}
