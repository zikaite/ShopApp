using Microsoft.EntityFrameworkCore;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<ItemTag> ItemTags { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemTag>().HasKey(bc => new {bc.TagId, bc.ItemId});

            modelBuilder.Entity<Item>().HasData(
                new Item()
                {                   
                    Id = 1,
                    Name = "Obuoliai",
                    ShopId = 2,
                    ExpiryDate = DateTime.UtcNow,
                },
                 new Item()
                 {               
                     Id = 2,
                     Name = "Sviestas",
                     ShopId = 1,
                     ExpiryDate = DateTime.UtcNow
                 },
                new Item()
                {
                    Id = 3,
                    Name = "Miltai",
                    ShopId = 1,
                    ExpiryDate = DateTime.UtcNow
                },
                new Item()
                {                   
                    Id = 4,
                    Name = "Kiausiniai",
                    ShopId = 1,
                    ExpiryDate = DateTime.UtcNow
                },
                new Item()
                {
                    Id = 5,
                    Name = "Cinamonas",
                    ShopId = 2,
                    ExpiryDate = DateTime.UtcNow
                }

                );
            modelBuilder.Entity<Shop>().HasData(
                new Shop()
                {
                    Id = 1,
                    Name = "Maxima"
                },
                new Shop()
                {
                    Id = 2,
                    Name = "Lidl"
                }
            );
        }
    }
}
