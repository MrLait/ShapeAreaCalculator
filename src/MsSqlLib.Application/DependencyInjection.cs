using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MsSqlLib.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMsSqlLibApplication(this IServiceCollection services) 
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
