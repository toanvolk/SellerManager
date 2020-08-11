using Microsoft.EntityFrameworkCore;
using SellerManager.Data.Entities;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using System.IO;

namespace SellerManager.Data.EF
{
    public class DbSellerManagerContext: DbContext
    {
        DbSet<Product> products { get; set; }
        DbSet<Customer> customers { get; set; }
        DbSet<PriceList> priceLists { get; set; }
        DbSet<PriceListDetail> priceListDetails { get; set; }
        public DbSellerManagerContext(DbContextOptions<DbSellerManagerContext> options)
            : base(options)
        {
        }

    }
    public class DbSellerManagerContextFactory : IDesignTimeDbContextFactory<DbSellerManagerContext>
    {    
        public DbSellerManagerContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../SellerManager.Api/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<DbSellerManagerContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new DbSellerManagerContext(builder.Options);
        }
    }
}
