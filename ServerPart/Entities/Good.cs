using System.Data.SqlClient;

namespace DataLayer.Entities;

public class Good : Entity
{
    public string Name { get; set; }

    public int Number { get; set; }

    public UnitOfMeasurement GoodType { get; set; }

    public int OrderId { get; set; }

    public  Order Order { get; set; }

    public override string GetAllValues()
    {
        return $"'{Name}', {Number}, {GoodType}, {OrderId}";
    }

    public override string GetAllDefindedValues()
    {
        return $"Name = '{Name}',Number =  {Number},GoodType = {GoodType},OrderId = {OrderId}";
    }

    public override void FillFromReader(SqlDataReader reader)
    {
        this.Id = (int)reader["Id"];
        this.Name = reader["Name"].ToString();
        this.Number = (int)reader["Number"];
        this.GoodType = (UnitOfMeasurement)Enum.Parse(typeof(UnitOfMeasurement), reader["GoodType"].ToString());
        this.OrderId = (int)reader["OrderId"];
    }

}


