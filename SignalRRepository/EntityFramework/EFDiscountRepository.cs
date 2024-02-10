using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFDiscountRepository:GenericRepository<Discount>,IDiscountRepository
{
    private readonly SignalRContext _context;
    public EFDiscountRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}