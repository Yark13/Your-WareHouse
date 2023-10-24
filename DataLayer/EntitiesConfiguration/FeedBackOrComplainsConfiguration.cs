using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer.EntitiesConfiguration;

internal class FeedBackOrComplainsConfiguration : IEntityTypeConfiguration<FeedbackOrComplains>
{
    public void Configure(EntityTypeBuilder<FeedbackOrComplains> builder)
    {
        builder.HasDiscriminator<string>("Discriminator").HasValue("FeedBackOrComplains");
        builder.HasData(new FillerDbData().FeedBacks);

        builder.HasOne(FC => FC.Customer).WithMany(C => C.FeedBacks).HasForeignKey(FC => FC.CustomerId);
    }
}