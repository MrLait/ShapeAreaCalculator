using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MsSqlLib.Domain.Entities;
using MsSqlLib.Persistence.InitialData;

namespace MsSqlLib.Persistence.EntityTypeConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(ProductInitData.Get());
        }
    }
}
