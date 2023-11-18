using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Entities;

namespace ServerPart;

public static class Server
{
    private static bool IsFree = true;
    private static TcpClient _servicedClient = new();
    private static string _connectionString = "Data Source=DESKTOP-BJ2VK09\\SQLEXPRESS;Initial Catalog=YourWareHouse;Integrated Security=True;Trusted_Connection=True;";
    private static SqlConnection _connection = new SqlConnection(_connectionString);

    public static TcpClient ConnectTcpClient(TcpClient client)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Try connect to server {client.Name}");
        if (IsFree)
        {
            IsFree = false;
            _servicedClient.Copy(client);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{client.Name} was be successfully connected");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{client.Name} could not connect to server");
        }
        Console.ForegroundColor = ConsoleColor.White;
        return client;
    }

    public static TcpClient GetCurrentTcpClientInfo()
    {
        return _servicedClient;
    }

    public static void DisconnectCurrentTcpClient(TcpClient initiatorClient)
    {
        if (initiatorClient.IP == _servicedClient.IP)
        {
            IsFree = true;
            _servicedClient = null;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_servicedClient.Name} was be successfully disconnected");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Waiting connecting");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{initiatorClient.Name} tried disconnect {_servicedClient.Name}");
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void OpenConnection()
    {
        if (_connection.State == ConnectionState.Closed)
        {
            try
            {
                _connection.Open();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Opened connecting to database");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, connect to basadate was be failed");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void CloseConnection()
    {
        if (_connection.State == ConnectionState.Open)
        {
            try
            {
                _connection.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Closed connecting to database");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, disconnect to basadate was be failed");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static DataTable ExecuteQuery(string query)
    {
        OpenConnection();
        var dataTable = new DataTable();
        try
        {
            using (var command = new SqlCommand(query, _connection))
            {
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Executing of the query \"{query}\" was successfully perfomed ");
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Executing of the query \"{query}\" was failed ");
        }
        Console.ForegroundColor = ConsoleColor.White;
        CloseConnection();
        return dataTable;
    }

    public static DataTable ExecuteQueryWithParameters(string query, SqlParameter[] parameters)
    {
        OpenConnection();
        var dataTable = new DataTable();

        try
        {
            using (var command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddRange(parameters);
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Executing of the query \"{query}\" was successfully perfomed ");
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Executing of the query \"{query}\" was failed ");
        }

        Console.ForegroundColor = ConsoleColor.White;

        CloseConnection();

        return dataTable;
    }

    public static void InsertItem<T>(T item) where T : Entity
    {
        string tableName = GetNameDatabase(typeof(T));
        // Складіть SQL-запит для вставки об'єкта `item` у таблицю `tableName`
        string query = $"INSERT INTO {tableName}  VALUES ({item.GetAllValues()})"; 

        ExecuteQuery(query);
    }

    public static void UpdateItem<T>(T item) where T : Entity
    {
        string tableName = GetNameDatabase(typeof(T));
        // Складіть SQL-запит для оновлення об'єкта `item` у таблиці `tableName` за певним ідентифікатором або іншою умовою
        string query = $"UPDATE {tableName} SET {item.GetAllDefindedValues()} WHERE Id = {item.Id}"; // Замініть (...) на відповідні значення та параметри.

        ExecuteQuery(query);
    }

    public static void DeleteItem<T>(int id) where T : Entity
    {
        string tableName = GetNameDatabase(typeof(T));
        // Складіть SQL-запит для видалення об'єкта з таблиці `tableName` за певним ідентифікатором або іншою умовою
        string query = $"DELETE FROM {tableName} WHERE Id = {id}"; // Замініть (...) на відповідні значення та параметри.

        ExecuteQuery(query);
    }

    public static Type GetTypeEntity(Type type)
    {
        Type NameDatabase;
        switch (type.Name)
        {
            case nameof(Manager):
                NameDatabase = typeof(Manager);
                break;
            case nameof(Customer):
                NameDatabase = typeof(Customer);
                break;
            case nameof(Order):
                NameDatabase = typeof(Order);
                break;
            case nameof(Article):
                NameDatabase = typeof(Article);
                break;
            case nameof(FeedbackOrComplains):
                NameDatabase = typeof(FeedbackOrComplains);
                break;
            case nameof(Good):
                NameDatabase = typeof(Good);
                break;
            default:
                NameDatabase = null;
                break;
        }

        return NameDatabase;
    }

    public static string GetNameDatabase(Type type)
    {
        string NameDatabase = "";
        switch (type.Name)
        {
            case nameof(Manager):
                NameDatabase = "Managers";
                break;
            case nameof(Customer):
                NameDatabase = "Customers";
                break;
            case nameof(Order):
                NameDatabase = "Orders";
                break;
            case nameof(Article):
                NameDatabase = "Articles";
                break;
            case nameof(FeedbackOrComplains):
                NameDatabase = "FeedbackOrComplains";
                break;
            case nameof(Good):
                NameDatabase = "Goods";
                break;
            default:
                NameDatabase = "unDefindedTypeException";
                break;
        }

        return NameDatabase;
    }
}
