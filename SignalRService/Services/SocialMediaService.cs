using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class SocialMediaService:GenericService<SocialMedia>,ISocialMediaService
{
    private readonly ISocialMediaRepository _socialMediaRepository;

    public SocialMediaService(ISocialMediaRepository socialMediaRepository) : base(socialMediaRepository)
    {
        _socialMediaRepository = socialMediaRepository;
    }
}