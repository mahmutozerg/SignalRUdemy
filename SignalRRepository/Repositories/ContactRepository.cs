using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class ContactRepository:GenericRepository<Contact>,IContactRepository
{
    private readonly SignalRContext _context;
    public ContactRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}