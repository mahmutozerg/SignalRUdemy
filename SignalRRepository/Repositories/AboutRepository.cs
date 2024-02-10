using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class AboutRepository:GenericRepository<About>,IAboutRepository
{
    private readonly SignalRContext _context;
    public AboutRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}