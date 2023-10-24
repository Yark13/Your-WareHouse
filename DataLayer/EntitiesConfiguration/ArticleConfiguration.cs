using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;

namespace DataLayer.EntitiesConfiguration;

internal class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasData(new FillerDbData().Articles);
    }
}