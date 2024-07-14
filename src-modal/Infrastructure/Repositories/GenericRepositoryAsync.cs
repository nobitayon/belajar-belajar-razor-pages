using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepositoryAsync<T> (ApplicationDbContext _dbContext) : IGenericRepositoryAsync<T> where T : class
{
   
    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }
    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        return entity;
    }
    public Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return Task.CompletedTask;
    }
    public Task DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        return Task.CompletedTask;
    }
    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        Console.WriteLine("It goes here");
        return await _dbContext.Set<T>().ToListAsync();
    }
}
