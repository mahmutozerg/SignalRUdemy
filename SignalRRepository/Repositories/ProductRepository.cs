using SignalR.Core.Repositories;
using SignalRApi.DAL.Entities;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class ProductRepository:GenericRepository<Product>,IProductRepository
{
    private readonly SignalRContext _context;
    public ProductRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}