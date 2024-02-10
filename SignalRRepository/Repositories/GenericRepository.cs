using Microsoft.EntityFrameworkCore;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;

namespace SignalRRepository.Repositories;

public class GenericRepository<TEntity>:IGenericRepository<TEntity> where TEntity: class
{
    private readonly SignalRContext _context;

    public GenericRepository(SignalRContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TEntity entity)
    {
        _context.Add(entity);
        await  _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();

    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task<List<TEntity>> GetListAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }
}