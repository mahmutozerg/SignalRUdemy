using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFContactRepository:GenericRepository<Contact>,IContactRepository
{
    private readonly SignalRContext _context;
    public EFContactRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}