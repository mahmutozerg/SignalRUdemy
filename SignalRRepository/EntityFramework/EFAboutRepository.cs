using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFAboutRepository:GenericRepository<About>,IAboutRepository
{
    private readonly SignalRContext _context;
    public EFAboutRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}