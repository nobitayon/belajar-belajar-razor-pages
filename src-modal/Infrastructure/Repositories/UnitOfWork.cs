using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UnitOfWork(ApplicationDbContext _dbContext) : IUnitOfWork
{
    private bool disposed;
    
    public async Task<int> Commit()
    {
        return await _dbContext.SaveChangesAsync();
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
        disposed = true;
    }
}
