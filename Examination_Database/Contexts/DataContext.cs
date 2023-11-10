
using Examination_Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.XPath;

namespace Examination_Database.Contexts;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<AdressEntity> Adresses {get; set;}
    public DbSet<CategoryEntity> Categories { get; set;}
    public DbSet<CustomerEntity> Customers { get; set;}
    public DbSet<OrderDetailsEntity> OrderDetails { get; set;}
    public DbSet<OrdersEntity> Orders { get; set;}
    public DbSet<PaymentsEntity> Payments { get; set;}
    public DbSet<ProductEntity> Products { get; set;}
    public DbSet<StockEntity> Stock { get; set;}
    public DbSet<SubCategoryEntity> SubCategories { get; set;}
    public DbSet<SupplierEntity> Suppliers { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetailsEntity>().HasKey(x => new { x.OrderId, x.ProductId });
    }
}
