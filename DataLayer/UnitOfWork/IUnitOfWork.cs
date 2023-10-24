using DataLayer.Entities;
using DataLayer.Repository;

namespace DataLayer.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    Repository<T> GetRepository<T>() where T : Entity;

    void SaveChanges();

    void Dispose();
}
