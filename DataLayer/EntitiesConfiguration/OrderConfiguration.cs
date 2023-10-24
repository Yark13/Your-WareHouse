using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer.EntitiesConfiguration;

internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasData(new FillerDbData().Orders);

        builder.HasOne(c => c.Customer).WithMany(o => o.Orders).HasForeignKey(c => c.CustomerId);
    }
}
