using Microsoft.EntityFrameworkCore;
using Shoppist.Domain.Products.Entities;

namespace Shoppist.Persistence.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Items { get; set; }
}