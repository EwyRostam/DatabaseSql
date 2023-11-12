using Examination_Database.Contexts;
using Examination_Database.Repositories;
using Examination_Database.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Examination_Database
{
    internal class Program
    {

        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ewyro\Nackademin\Databas_16\Examination\Examination_Database\Contexts\DataBases\DB_Examination.mdf;Integrated Security=True;Connect Timeout=30";
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
            {
                services.AddDbContext<DataContext>(x => x.UseSqlServer(connectionString));

                services.AddScoped<AdressRepository>();
                services.AddScoped<CategoryRepository>();
                services.AddScoped<ProductRepository>();
                services.AddScoped<CustomerRepository>();
                services.AddScoped<OrderDetailsRepository>();
                services.AddScoped<OrderRepository>();
                services.AddScoped<PaymentsRepository>();
                services.AddScoped<StockRepository>();
                services.AddScoped<SubCategoryRepository>();
                services.AddScoped<SupplierRepository>();
                
                services.AddScoped<CategoryService>();
                services.AddScoped<ProductService>();
                services.AddScoped<CustomerService>();
                services.AddScoped<MenuService>();

                using var sp = services.BuildServiceProvider();
                var menuService = sp.GetService<MenuService>(); 

            }).Build();

            await host.RunAsync();
        }

    }

}