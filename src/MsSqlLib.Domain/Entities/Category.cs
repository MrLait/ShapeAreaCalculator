using System.ComponentModel.DataAnnotations.Schema;

namespace MsSqlLib.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Many-to-many
        //[NotMapped]
        public List<Product>? Products { get; set; }
    }
}
