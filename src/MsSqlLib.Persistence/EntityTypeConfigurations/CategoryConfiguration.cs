using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MsSqlLib.Domain.Entities;
using MsSqlLib.Persistence.InitialData;

namespace MsSqlLib.Persistence.EntityTypeConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasMany(x => x.Products)
                .WithMany(x => x.Categories)
                .UsingEntity<CategoryProduct>();

            builder.HasData(CategoryInitData.Get());
        }
    }
}
