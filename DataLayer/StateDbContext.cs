using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DataLayer.Entities;
using DataLayer.EntitiesConfiguration;

namespace DataLayer;

public class StateDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public virtual DbSet<Customer> Customers{ get; set; } = default!;
    public virtual DbSet<Manager> Managers { get; set; } = default!;
    public virtual DbSet<Order> Orders{ get; set; } = default!;
    public virtual DbSet<FeedbackOrComplains> FeedBackOrComplains { get; set; } = default!;
    public virtual DbSet<Article> Articles { get; set; } = default!;
    public virtual DbSet<Good> Goods { get; set; } = default!;

    public StateDbContext()
    {
       // Database.EnsureCreated();
    }

    public StateDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Data Source=DESKTOP-BJ2VK09\\SQLEXPRESS;Initial Catalog=YourWareHouse;Integrated Security=True;Trusted_Connection=True;Trust Server Certificate=true;");

        base.OnConfiguring(options);


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomersConfiguration());
        modelBuilder.ApplyConfiguration(new ManagerConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new FeedBackOrComplainsConfiguration());
        modelBuilder.ApplyConfiguration(new ArticleConfiguration());
    }
}