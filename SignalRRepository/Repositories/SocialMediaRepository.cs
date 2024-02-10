using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class SocialMediaRepository:GenericRepository<SocialMedia>,ISocialMediaRepository
{
    private readonly SignalRContext _context;
    public SocialMediaRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}