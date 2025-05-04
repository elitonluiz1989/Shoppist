using Microsoft.EntityFrameworkCore;
using Shoppist.Domain.Products.Shared;

namespace Shoppist.Persistence.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Item> Items { get; set; }
}