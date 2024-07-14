namespace Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> Commit();
}


