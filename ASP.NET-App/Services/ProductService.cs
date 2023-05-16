using ASP.NET_App.Models.Entities;
using ASP.NET_App.Repositories;

namespace ASP.NET_App.Services;

public class ProductService
{
    private readonly ProductRepository _productRepository;

    public ProductService(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task CreateAsync(ProductEntity productEntity)
    {
        await _productRepository.AddAsync(productEntity);
    }
}
