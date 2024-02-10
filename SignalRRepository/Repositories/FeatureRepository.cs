using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class FeatureRepository:GenericRepository<Feature>,IFeatureRepository
{
    private readonly SignalRContext _context;
    public FeatureRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}