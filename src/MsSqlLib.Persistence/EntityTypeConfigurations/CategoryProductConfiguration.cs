using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MsSqlLib.Domain.Entities;
using MsSqlLib.Persistence.InitialData;

namespace MsSqlLib.Persistence.EntityTypeConfigurations
{
    public class CategoryProductConfiguration : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasData(CategoryProductInitData.Get());
        }
    }
}
