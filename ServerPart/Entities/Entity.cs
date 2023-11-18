using System.Data;
using System.Data.SqlClient;

namespace DataLayer.Entities;

public abstract class Entity
{
    public int Id { get; set; }

    public abstract string GetAllValues();

    public abstract string GetAllDefindedValues();

    public abstract void FillFromReader(SqlDataReader reader);
}