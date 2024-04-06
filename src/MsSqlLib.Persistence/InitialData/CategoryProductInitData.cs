using MsSqlLib.Domain.Entities;

namespace MsSqlLib.Persistence.InitialData
{
    public static class CategoryProductInitData
    {
        public static List<CategoryProduct> Get()
        {
            return new List<CategoryProduct>
            {
                new CategoryProduct { ProductId = 1, CategoryId = 1 },
                new CategoryProduct { ProductId = 2, CategoryId = 2 },
                new CategoryProduct { ProductId = 3, CategoryId = 3 },
                new CategoryProduct { ProductId = 4, CategoryId = 4 },
                new CategoryProduct { ProductId = 5, CategoryId = 5 }
            };
        }
    }
}
