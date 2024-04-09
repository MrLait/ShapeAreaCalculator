using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsSqlLib.Application.Common.Interfaces;

namespace MsSqlLib.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
                
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            var serviceCollection = services.AddScoped<IApplicationDbContext>
            (
                provider => provider.GetService<ApplicationDbContext>()!
            );
            return services;
        }
    }
}
