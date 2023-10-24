using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer.EntitiesConfiguration;

internal class CustomersConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasData(new FillerDbData().Cusomers);
    }
}
