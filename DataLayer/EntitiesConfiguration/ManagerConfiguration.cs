using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer.EntitiesConfiguration;

internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
{
    public void Configure(EntityTypeBuilder<Manager> builder)
    {
        builder.HasData(new FillerDbData().Managers);
    }
}
