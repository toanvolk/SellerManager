using System;
using System.Collections.Generic;
using System.Text;
using SellerManager.Data.Entities;
using System.Linq;
namespace SellerManager.Data.EF.SeedData
{
    public class SeedData
    {
        public static void Initialize(DbSellerManagerContext context)
        {
            if(!context.Set<Product>().Any())
            {
                List<Product> products = new List<Product>()
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
                context.Set<Product>().AddRange(products);
                context.SaveChanges();
            }    

            if(!context.Set<Customer>().Any())
            {
                List<Customer> list = new List<Customer>() {
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

                context.Set<Customer>().AddRange(list);
                context.SaveChanges();
            }    
        }
    }
}
