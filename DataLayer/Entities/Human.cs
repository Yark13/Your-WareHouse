namespace DataLayer.Entities;

public class Human : Entity
{
    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string Name => LastName + " " + FirstName;

    public string Login { get; set; }

    public string PasswordHash { get; set; }
}