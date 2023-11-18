using DataLayer.Entities;
using DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using ServerPart;

namespace DataLayer.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private bool disposed;
    private TcpClient _сlient;

    public UnitOfWork()
    {
        _сlient = new();
        _сlient.Connect();
    }

    public Repository<T> GetRepository<T>() where T : Entity
    {
        return new Repository<T>( _сlient);
    }

    public void SaveChanges()
    {
        
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed && disposing)
        {
            
        }
        this.disposed = true;
    }

    ~UnitOfWork(){
        Server.DisconnectCurrentTcpClient(_сlient);
    }

}
