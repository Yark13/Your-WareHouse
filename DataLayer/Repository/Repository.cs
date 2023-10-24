using System.Data;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;
using System.Linq.Expressions;

namespace DataLayer.Repository;

public class Repository<T> : IRepository<T> where T : Entity
{
    internal DbContext _context;
    internal DbSet<T> _dbSet = default!;

    public Repository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException();
        _dbSet = _context.Set<T>() ?? throw new ArgumentNullException();
    }

    public virtual IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
    {
        IQueryable<T> query = _dbSet;

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
        return _dbSet.AsQueryable();
    }

    public virtual void Insert(T entity)
    {
        _dbSet.Add(entity);
    }

    public virtual void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public void Save()
    {
        new UnitOfWork.UnitOfWork(_context).SaveChanges();
    }

    public T Find(int id)
    {
        return _context.Find<T>(id);
    }

    public bool EntityExists(string login)
    {
        if (typeof(T).IsSubclassOf(typeof(Human)) || typeof(T) == typeof(Human))
        {
            return _dbSet.Cast<Human>().Any(e => e.Login == login);
        }

        return false;
    }

    public Human Find(string login)
    {
        if (typeof(T).IsSubclassOf(typeof(Human)) || typeof(T) == typeof(Human))
        {
            return _dbSet.Cast<Human>().FirstOrDefault(e => e.Login == login);
        }

        return null;
    }
}