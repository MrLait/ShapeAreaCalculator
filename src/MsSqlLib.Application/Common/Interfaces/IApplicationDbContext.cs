using Microsoft.EntityFrameworkCore;
using MsSqlLib.Domain.Entities;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace MsSqlLib.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<CategoryProduct> CategoryProducts { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
