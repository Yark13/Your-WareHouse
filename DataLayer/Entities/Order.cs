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

    public UnitOfMeasurement GoodType { get; set; }

    public string? CustomerComment { get; set; }

    public string? ManagerComment { get; set; }
}