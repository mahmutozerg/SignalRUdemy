﻿namespace SignalR.Core.Repositories;
public interface IGenericRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> GetByIdAsync(int id);
    Task<List<TEntity>> GetListAllAsync();
    
}