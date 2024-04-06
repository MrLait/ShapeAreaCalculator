namespace MsSqlLib.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Many-to-many
        public ICollection<Category>? Categories { get; set; }
    }
}
