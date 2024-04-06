namespace MsSqlLib.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Many-to-many
        public ICollection<Product>? Products { get; set; }
    }
}
