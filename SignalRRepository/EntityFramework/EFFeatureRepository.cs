using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFFeatureRepository:GenericRepository<Feature>,IFeatureRepository
{
    private readonly SignalRContext _context;
    public EFFeatureRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}