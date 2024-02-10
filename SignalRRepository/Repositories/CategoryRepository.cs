using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
{
    private readonly SignalRContext _context;
    public CategoryRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}