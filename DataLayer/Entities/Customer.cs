namespace DataLayer.Entities;

public class Customer : Human
{
    public List<Order> Orders { get; set; } = new();

    public List<FeedbackOrComplains> FeedBacks { get; set; } = new();
}
