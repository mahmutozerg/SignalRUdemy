using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class GenericService<TEntity>:IGenericService<TEntity> where TEntity : class
{
    private readonly IGenericRepository<TEntity> _repository;

    public GenericService(IGenericRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        await _repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(TEntity entity)
    {
        await _repository.DeleteAsync(entity);
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<List<TEntity>> GetListAllAsync()
    {
        return await _repository.GetListAllAsync();
    }
}