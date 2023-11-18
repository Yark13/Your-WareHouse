
using System.Data;
using System.Reflection;
using DataLayer.Entities;

namespace ServerPart;

public class TcpClient
{
    public int IP = 0;
    public string Name => "TcpClient #" + IP;
    private static int id = 0;

    public TcpClient()
    {
        IP = id;
        id++;
    }

    public void Connect()
    {
       this.Copy(Server.ConnectTcpClient(this));
    }

    public void Copy(TcpClient tcpClient)
    {
        this.IP = tcpClient.IP;
    }

    public DataTable GetAll<T>() where T : Entity
    {
        return Server.ExecuteQuery($"Select * from {Server.GetNameDatabase(typeof(T))}");
    }

    public IQueryable<T> GetEntitiesFromDataTable<T>(DataTable dataTable) where T : Entity
    {
        List<T> entities = new List<T>();

        foreach (DataRow row in dataTable.Rows)
        {
            T entity = CreateEntityFromDataRow<T>(typeof(T), row);
            entities.Add(entity);
        }

        return entities.AsQueryable();
    }

    public void Insert<T>(T item) where T : Entity
    {
        Server.InsertItem(item);
    }

    public void Update<T>(T item) where T : Entity
    {
        Server.UpdateItem(item);
    }

    public T Find<T>(int id) where T : Entity
    {
        DataTable dataTable = GetAll<T>(); // Отримуємо всі сутності з бази даних

        DataRow[] rows = dataTable.Select("Id = " + id); // Пошук за ідентифікатором (припускаючи, що ідентифікатор зберігається в стовпці "Id")

        if (rows.Length > 0)
        {
            // Якщо знайдено, отримуємо тип класу T
            Type entityType = typeof(T);

            // Створюємо об'єкт класу T за допомогою фабричного методу (можливо, вам потрібно мати такий метод у своєму абстрактному класі T)
            T item = CreateEntityFromDataRow<T>(entityType, rows[0]);

            // Повертаємо створений об'єкт
            return item;
        }

        // Якщо сутність не знайдено, повертаємо null або робите іншу обробку за потребою.
        return null;
    }

    public void Remove<T>(T item) where T : Entity
    {
        Delete<T>(item.Id);
    }

    public void Delete<T>(int id) where T : Entity
    {
        Server.DeleteItem<T>(id);
    }

    public T CreateEntityFromDataRow<T>(Type entityType, DataRow row)
    {
        T item = (T)Activator.CreateInstance(entityType); // Створення об'єкта

        // Встановлення значень всіх властивостей, включаючи успадковані властивості від Entity
        foreach (PropertyInfo propertyInfo in entityType.GetProperties())
        {
            if (row.Table.Columns.Contains(propertyInfo.Name)) // Перевірка, чи існує відповідний стовпець у DataTable
            {
                object value = row[propertyInfo.Name];
                if (value != DBNull.Value)
                {
                    // Встановлення значення властивості за допомогою Reflection
                    propertyInfo.SetValue(item, value);
                }
            }
        }

        return item;
    }

    ~TcpClient()
    {
        Server.DisconnectCurrentTcpClient(this);
    }

    

}
