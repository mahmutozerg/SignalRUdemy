using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class AboutService:GenericService<About>,IAboutService
{
    private readonly IAboutRepository _aboutRepository;

    public AboutService(IAboutRepository aboutRepository):base(aboutRepository)
    {
        _aboutRepository = aboutRepository;
    }
}