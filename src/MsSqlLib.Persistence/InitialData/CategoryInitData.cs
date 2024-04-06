using MsSqlLib.Domain.Entities;

namespace MsSqlLib.Persistence.InitialData
{
    public static class CategoryInitData
    {
        public static List<Category> Get()
        {
            return new List<Category>
            {
                new Category {Id= 1, Name = "Electronics" },
                new Category {Id= 2, Name = "Clothing" },
                new Category {Id= 3, Name = "Books" },
                new Category {Id= 4, Name = "Furniture" },
                new Category {Id = 5, Name = "Sports" },
                new Category {Id= 6, Name = "Beauty" },
                new Category {Id = 7, Name = "Home Appliances" },
                new Category {Id = 8, Name = "Toys" },
                new Category {Id = 9, Name = "Tools" },
                new Category {Id = 10, Name = "Jewelry" }
            };
        }
    }
}
