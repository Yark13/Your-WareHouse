namespace DataLayer.Entities;

public class Good : Entity
{
    public string Name { get; set; }

    public int Number { get; set; }

    public UnitOfMeasurement GoodType { get; set; }

    public int OrderId { get; set; }

    public  Order Order { get; set; }
}


