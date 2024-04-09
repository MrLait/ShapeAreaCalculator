using Microsoft.EntityFrameworkCore;
using MsSqlLib.Application.Common.Interfaces;
using MsSqlLib.Domain.Entities;
using System.Reflection;

namespace MsSqlLib.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<CategoryProduct> CategoryProducts { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
            
        }
    }
}
