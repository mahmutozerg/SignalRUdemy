using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFCategoryRepository:GenericRepository<Category>,ICategoryRepository
{
    private readonly SignalRContext _context;
    public EFCategoryRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}