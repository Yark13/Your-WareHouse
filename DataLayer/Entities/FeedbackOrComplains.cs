namespace DataLayer.Entities;

public class FeedbackOrComplains :Entity
{
    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime DatePublication { get; set; }

    public int CustomerId { get; set; }

    public Customer? Customer { get; set; }
}
