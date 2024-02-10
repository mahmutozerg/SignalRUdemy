using SignalR.Core.Repositories;
using SignalRApi.DAL.Entities;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFProductRepository:GenericRepository<Product>,IProductRepository
{
    private readonly SignalRContext _context;
    public EFProductRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}