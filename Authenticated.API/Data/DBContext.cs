using Microsoft.EntityFrameworkCore;
using Autheticated.models;

namespace Authenticated_API;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Shopping_Cart> ShoppingCarts { get; set; }
}