using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using eCommerceDotNetCoreMVC.web.Models; // Import your models

namespace eCommerceDotNetCoreMVC.web.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Check if there is any existing data
                if (context.Product.Any())
                {
                    return; // Database has been seeded
                }

                // Seed initial products
                var products = new Product[]
                {
                    new Product
                    {
                        Name = "Product 1",
                        Description = "Description for Product 1",
                        Price = 19.99m,
                        Category = "Category 1",
                        Brand = "Brand 1",
                        InStock = true,
                        ImageUrl = "url-to-image-for-product-1.jpg",
                        Discount = 0 // Set discount if applicable
                    },
                    // Add more initial products as needed
                };

                // Add products to the context
                context.Product.AddRange(products);

                // Save changes to the database
                context.SaveChanges();
            }
        }
    }
}
