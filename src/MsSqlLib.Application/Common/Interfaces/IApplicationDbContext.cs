using Microsoft.EntityFrameworkCore;
using MsSqlLib.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MsSqlLib.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<CategoryProduct> CategoryProducts { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
