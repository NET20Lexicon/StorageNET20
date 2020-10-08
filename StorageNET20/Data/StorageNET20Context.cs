using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StorageNET20.Models;

namespace StorageNET20.Data
{
    public class StorageNET20Context : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public StorageNET20Context (DbContextOptions<StorageNET20Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 1,
                  Name = "Iphone",
                  Category = "Mobile",
                  Count = 156,
                  Description = "Stupid",
                  OrderDate = DateTime.Now.AddDays(-6),
                  Price = 15600,
                  Shelf = "4B"
              }, new Product
              {
                  Id = 2,
                  Name = "S10",
                  Category = "Mobile",
                  Count = 98,
                  Description = "Better",
                  OrderDate = DateTime.Now.AddDays(-23),
                  Price = 12450,
                  Shelf = "4C"
              }, new Product
              {
                  Id = 3,
                  Name = "MacBook",
                  Category = "Computers",
                  Count = 23,
                  Description = "Stupid",
                  OrderDate = DateTime.Now.AddDays(-5),
                  Price = 45600,
                  Shelf = "4C"
              }, new Product
              {
                  Id = 4,
                  Name = "Suface X",
                  Category = "Computer",
                  Count = 32,
                  Description = "Stupid",
                  OrderDate = DateTime.Now.AddDays(-40),
                  Price = 26850,
                  Shelf = "5C"
              }, new Product
              {
                  Id = 5,
                  Name = "Pen",
                  Category = "Office Supplies",
                  Count = 15651,
                  Description = "Stupid",
                  OrderDate = DateTime.Now.AddDays(-6),
                  Price = 1,
                  Shelf = "45W"
              }

              );
        }

    }
}
