using MsSqlLib.Domain.Entities;

namespace MsSqlLib.Persistence.InitialData
{
    public static class ProductInitData
    {
        public static List<Product> Get() 
        {
            return new List<Product>
            {
                new Product {Id=1, Name = "Smartphone" },
                new Product {Id=2, Name = "T-shirt" },
                new Product {Id=3, Name = "Harry Potter Book" },
                new Product {Id=4, Name = "Sofa" },
                new Product {Id=5, Name = "Football" }
            };
        }
    }
}
