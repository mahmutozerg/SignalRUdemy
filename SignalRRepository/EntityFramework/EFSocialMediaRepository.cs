using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFSocialMediaRepository:GenericRepository<SocialMedia>,ISocialMediaRepository
{
    private readonly SignalRContext _context;
    public EFSocialMediaRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}