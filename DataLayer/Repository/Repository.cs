using System.Data;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;
using System.Linq.Expressions;
using ServerPart;

namespace DataLayer.Repository;

public class Repository<T> : IRepository<T> where T : Entity
{
    private TcpClient _сlient;
    private DataTable table;

    public Repository( TcpClient client)
    {
        _сlient = client;
        table = _сlient.GetAll<T>();
    }

    public virtual IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
    {
        IQueryable<T> query = _сlient.GetEntitiesFromDataTable<T>(table);

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
        {
            return orderBy(query).ToList();
        }
        else
        {
            return query.ToList();
        }
    }

    public virtual IQueryable<T> GetQueryable()
    {
        return _сlient.GetEntitiesFromDataTable<T>(table);
    }

    public virtual void Insert(T entity)
    {
        _сlient.Insert(entity);
    }

    public virtual void Update(T entity)
    {
        _сlient.Update(entity);
    }

    public void Delete(T entity)
    {
        _сlient.Remove(entity);
    }

    public void Save()
    {
       
    }

    public T Find(int id)
    {
        return _сlient.Find<T>(id);
    }

    public bool EntityExists(string login)
    {
        if (typeof(T).IsSubclassOf(typeof(Human)) || typeof(T) == typeof(Human))
        {
            return GetQueryable().Cast<Human>().Any(e => e.Login == login);
        }

        return false;
    }

    public Human Find(string login)
    {
        if (typeof(T).IsSubclassOf(typeof(Human)) || typeof(T) == typeof(Human))
        {
            return GetQueryable().Cast<Human>().FirstOrDefault(e => e.Login == login);
        }

        return null;
    }
}