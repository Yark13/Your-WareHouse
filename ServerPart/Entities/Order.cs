using System.Data.SqlClient;

namespace DataLayer.Entities;

public class Order : Entity
{
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public DateTime StartReservation { get; set; }

    public DateTime EndReservation { get; set; }

    public StatusOrder OrderStatus { get; set; }

    public string? GoodName { get; set; }

    public int GoodNumber { get; set; }

    public UnitOfMeasurement GoodType { get; set; } = UnitOfMeasurement.SquareMeters;

    public string? CustomerComment { get; set; }

    public string? ManagerComment { get; set; }

    public override string GetAllValues()
    {
        return $"{CustomerId}, '{CustomerComment}', '{ManagerComment}', '{EndReservation.ToString("yyyy-MM-dd")}', {Convert.ToInt32(OrderStatus)}, '{StartReservation.ToString("yyyy-MM-dd")}', {Convert.ToInt32(GoodType)}, '{GoodName}', {GoodNumber}";
    }

    public override string GetAllDefindedValues()
    {
        return $"CustomerId = {CustomerId}, CustomerComment = '{CustomerComment}', ManagerComment = '{ManagerComment}', EndReservation = '{EndReservation.ToString("yyyy-MM-dd")}', OrderStatus = {Convert.ToInt32(OrderStatus)}, StartReservation = '{StartReservation.ToString("yyyy-MM-dd")}', GoodType = {Convert.ToInt32(GoodType)}, GoodName = '{GoodName}', GoodNumber = {GoodNumber}";
    }


    public override void FillFromReader(SqlDataReader reader)
    {
        this.Id = (int)reader["Id"];
        this.CustomerId = (int)reader["CustomerId"];
        this.CustomerComment = reader["CustomerComment"].ToString();
        this.ManagerComment = reader["ManagerComment"].ToString();
        this.EndReservation = (DateTime)reader["EndReservation"];
        this.OrderStatus = (StatusOrder)Enum.Parse(typeof(StatusOrder), reader["OrderStatus"].ToString());
        this.StartReservation = (DateTime)reader["StartReservation"];
        this.GoodType = (UnitOfMeasurement)Enum.Parse(typeof(UnitOfMeasurement), reader["GoodType"].ToString());
        this.GoodName = reader["GoodName"].ToString();
        this.GoodNumber = (int)reader["GoodNumber"];
    }

}