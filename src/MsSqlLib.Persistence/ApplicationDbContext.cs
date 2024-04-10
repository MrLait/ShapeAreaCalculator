using Microsoft.EntityFrameworkCore;
using MsSqlLib.Application.Common.Interfaces;
using MsSqlLib.Domain.Entities;
using System.Data;
using System.Reflection;

namespace MsSqlLib.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<CategoryProduct> CategoryProducts { get; set; } = null!;

        public IDbConnection Connection => Database.GetDbConnection();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        //public async void GetTest()
        //{
        //    var testt = this.Categories.FromSql(
        //        @$"
        //        SELECT 
        //            Categories.id, 
        //            Categories.Name,
        //        FROM Categories
        //        LEFT JOIN CategoryProducts 
        //            ON CategoryProducts.CategoryId = Categories.id
        //        LEFT JOIN Products 
        //            ON Products.Id = CategoryProducts.ProductId
        //        ").Include(p => p.Products);

        //    var list = testt.ToList();
        //}
    }
}
