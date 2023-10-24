using DataLayer.Entities;
using DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    private bool disposed;

    public UnitOfWork(DbContext context)
    {
        _context = context;
    }

    public Repository<T> GetRepository<T>() where T : Entity
    {
        return new Repository<T>(_context);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
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
            _context.Dispose();
        }
        this.disposed = true;
    }


}
