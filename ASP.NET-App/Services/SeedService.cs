using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

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
            // Check if categories and products already exist
            var categoriesExist = await _context.Category.AnyAsync();
            var productsExist = await _context.Products.AnyAsync();

            if (!categoriesExist && !productsExist)
            {
                var newCategory = new CategoryEntity { Id = 1, Name = "New" };
                var popularCategory = new CategoryEntity { Id = 2, Name = "Popular" };
                var featuredCategory = new CategoryEntity { Id = 3, Name = "Featured" };

                var categories = new List<CategoryEntity> { newCategory, popularCategory, featuredCategory };

                var seedData = JArray.Parse(File.ReadAllText(@"Services\seed-data.json"));
                var products = new List<ProductEntity>();

                foreach (var item in seedData)
                {
                    var product = item.ToObject<ProductEntity>();
                    product!.ProductCategories = new List<ProductCategoryEntity>();

                    // Check if "ProductCategories" property exists and is not null
                    if (item["ProductCategories"] is JArray productCategories)
                    {
                        foreach (var category in productCategories)
                        {
                            var categoryId = category.Value<int>("CategoryId");

                            if (categoryId == 1)
                                product.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 1, Category = newCategory });
                            else if (categoryId == 2)
                                product.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 2, Category = popularCategory });
                            else if (categoryId == 3)
                                product.ProductCategories.Add(new ProductCategoryEntity { CategoryId = 3, Category = featuredCategory });
                        }
                    }

                    products.Add(product);
                }

                _context.Category.AddRange(categories);
                _context.Products.AddRange(products);
                await _context.SaveChangesAsync();
            }
        }
    }
}