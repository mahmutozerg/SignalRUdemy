using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class FeatureService:GenericService<Feature>,IFeatureService
{
    private readonly IFeatureRepository _featureRepository;

    public FeatureService(IFeatureRepository featureRepository):base(featureRepository)
    {
        _featureRepository = featureRepository;
    }
}