namespace SignalR.Core.Services;

public interface IGenericService<TEntity> where TEntity: class
{
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity?> GetByIdAsync(int id);
    Task<List<TEntity>> GetListAllAsync();
}