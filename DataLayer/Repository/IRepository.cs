using DataLayer.Entities;
using System.Linq.Expressions;

namespace DataLayer.Repository;

public interface IRepository<T> where T : Entity
{
    IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

    IQueryable<T> GetQueryable();

    void Insert(T entity);
                
    void Update(T entity);
                
    void Delete(T entity);

    void Save();

    T Find(int id);

    bool EntityExists(string login);

    Human Find(string login);
}