﻿using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            if (productCollection.Find(p => true).Any())
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "8242398ruqwh98u3298r829q3yr982q",
                    Name = "AlienWare",
                    Description = "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare " +
                    "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare " +
                    "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare " +
                    "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare ",
                    Image = "product-1.png",
                    Price = 1000.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "8242398ruqwh2342398u3298r829q3yr982q",
                    Name = "Samsung",
                    Description = "Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung " +
                    "Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung " +
                    "Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung " +
                    "Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung Samsung ",
                    Image = "product-2.png",
                    Price = 900.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "8242398vdvdruqwh98u3298r829q3yr982q",
                    Name = "Asus",
                    Description = "Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus " +
                    "Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus " +
                    "Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus " +
                    "Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus Asus ",
                    Image = "product-3.png",
                    Price = 2000.00M,
                    Category = "Computer"
                },
                new Product()
                {
                    Id = "8242398fhfgruqwh98u3298r829q3yr982q",
                    Name = "Dell",
                    Description = "Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell " +
                    "Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell " +
                    "Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell " +
                    "Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell Dell ",
                    Image = "product-4.png",
                    Price = 3000.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "8242398rjyyjuqwh98u3298r829q3yr982q",
                    Name = "Macbook",
                    Description = "Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook " +
                    "Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook " +
                    "Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook " +
                    "Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook Macbook ",
                    Image = "product-5.png",
                    Price = 4000.00M,
                    Category = "Computer"
                },
                new Product()
                {
                    Id = "824239835435ruqwh98u3298r829q3yr982q",
                    Name = "AlienWare",
                    Description = "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare " +
                    "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare " +
                    "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare " +
                    "AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare AlienWare ",
                    Image = "product-6.png",
                    Price = 3500.00M,
                    Category = "Computer"
                }
            };
        }
    }
}
