using Examination_Database.Contexts;
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
            }).Build();

            await host.RunAsync();
        }

    }

}