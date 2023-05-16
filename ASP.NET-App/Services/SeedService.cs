using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Services
{
    public class SeedService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppContexts _context;

        public SeedService(RoleManager<IdentityRole> roleManager, AppContexts context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync("admin"))
                await _roleManager.CreateAsync(new IdentityRole("admin"));

            if (!await _roleManager.RoleExistsAsync("user"))
                await _roleManager.CreateAsync(new IdentityRole("user"));
        }

        public async Task SeedCategories()
        {
            // Check if categories already exist
            var categoriesExist = await _context.Category.AnyAsync();

            if (!categoriesExist)
            {
                // Create and seed the three categories
                var newCategory = new CategoryEntity { Name = "New" };
                var popularCategory = new CategoryEntity { Name = "Popular" };
                var featuredCategory = new CategoryEntity { Name = "Featured" };

                _context.Category.AddRange(newCategory, popularCategory, featuredCategory);
                await _context.SaveChangesAsync();

                // Check if products already exist
                var productsExist = await _context.Products.AnyAsync();

                if (!productsExist)
                {
                    var products = new List<ProductEntity>();

                    for (int i = 1; i <= 20; i++)
                    {
                        // Create and seed the products
                        var product = new ProductEntity
                        {
                            ArticleNumber = $"P{i}",
                            ProductName = $"Product {i}",
                            Ingress = $"Ingress {i}",
                            Description = $"Description {i}",
                            Price = i * 10,
                            ProductCategories = new List<ProductCategoryEntity>()
                        };

                        // Assign the product to each category
                        if (i % 2 == 0)
                        {
                            product.ProductCategories.Add(new ProductCategoryEntity { CategoryId = newCategory.Id });
                        }
                        if (i % 3 == 0)
                        {
                            product.ProductCategories.Add(new ProductCategoryEntity { CategoryId = popularCategory.Id });
                        }
                        if (i % 4 == 0)
                        {
                            product.ProductCategories.Add(new ProductCategoryEntity { CategoryId = featuredCategory.Id });
                        }

                        // Set the product image
                        var imageName = $"Image{i}.svg";
                        var imagePath = $"/images/placeholders/{imageName}";
                        var imageBytes = await File.ReadAllBytesAsync($"wwwroot{imagePath}");
                        product.ProductImage = imageBytes;

                        products.Add(product);
                    }

                    _context.Products.AddRange(products);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}