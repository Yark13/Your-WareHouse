using System.Data.SqlClient;

namespace DataLayer.Entities;

public class Human : Entity
{
    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string Name => LastName + " " + FirstName;

    public string Login { get; set; }

    public string PasswordHash { get; set; }

    public override string GetAllValues()
    {
        return $"'{LastName}', '{FirstName}', '{Login}', '{PasswordHash}'";
    }

    public override string GetAllDefindedValues()
    {
        return $"LastName = '{LastName}', FirstName = '{FirstName}', Login = '{Login}', PasswordHash = '{PasswordHash}'";
    }

    public override void FillFromReader(SqlDataReader reader)
    {
        this.Id = (int)reader["Id"];
        this.LastName = reader["LastName"].ToString();
        this.FirstName = reader["FirstName"].ToString();
        this.Login = reader["Login"].ToString();
        this.PasswordHash = reader["PasswordHash"].ToString();
    }
}