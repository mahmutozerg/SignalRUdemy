using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class AboutServices:IAboutService
{
    private readonly IAboutRepository _aboutRepository;

    public AboutServices(IAboutRepository aboutRepository)
    {
        _aboutRepository = aboutRepository;
    }

    public async Task AddAsync(About entity)
    {
        await _aboutRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(About entity)
    {
        await _aboutRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(About entity)
    {
        await _aboutRepository.DeleteAsync(entity);
    }

    public async Task<About> GetByIdAsync(int id)
    {
        return await _aboutRepository.GetByIdAsync(id);
    }

    public async Task<List<About>> GetListAllAsync()
    {
        return await _aboutRepository.GetListAllAsync();
    }
}