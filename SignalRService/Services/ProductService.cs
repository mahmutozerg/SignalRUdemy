using SignalR.Core.Repositories;
using SignalR.Core.Services;
using SignalRApi.DAL.Entities;

namespace SignalRService.Services;

public class ProductService:GenericService<Product>,IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository) : base(productRepository)
    {
        _productRepository = productRepository;
    }
}