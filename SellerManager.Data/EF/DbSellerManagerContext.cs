using Microsoft.EntityFrameworkCore;
using SellerManager.Data.Entities;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using System.IO;
using System;
using System.Collections.Generic;

namespace SellerManager.Data.EF
{
    public class DbSellerManagerContext: DbContext
    {        
        public DbSellerManagerContext(DbContextOptions<DbSellerManagerContext> options)
            : base(options)
        {
        }
        DbSet<Product> Products { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<PriceList> PriceLists { get; set; }
        DbSet<PriceListDetail> PriceListDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<PriceList>().ToTable("PriceList");
            modelBuilder.Entity<PriceListDetail>().ToTable("PriceListDetail");


            List<Product> productsList = new List<Product>()
                {
                    new Product(){
                        ProductId = "SPYT001",
                        Name = "Sản phẩm Y tế 001",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },
                    new Product(){
                        ProductId = "SPYT002",
                        Name = "Sản phẩm Y tế 002",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },new Product(){
                        ProductId = "SPYT003",
                        Name = "Sản phẩm Y tế 003",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },new Product(){
                        ProductId = "SPYT004",
                        Name = "Sản phẩm Y tế 004",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },
                };
            modelBuilder.Entity<Product>().HasData(productsList);

            List<Customer> customerList = new List<Customer>() {
                    new Customer(){
                        CustomerId = "KH0001",
                        Name = "Khách hàng A",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },
                    new Customer(){
                        CustomerId = "KH0002",
                        Name = "Khách hàng B",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },
                    new Customer(){
                        CustomerId = "KH0003",
                        Name = "Khách hàng C",
                        CreateDate = DateTime.Now,
                        CreateBy = "admin"
                    },
                };
            modelBuilder.Entity<Customer>().HasData(customerList);
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
