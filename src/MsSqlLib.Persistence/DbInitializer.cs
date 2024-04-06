using Microsoft.EntityFrameworkCore;

namespace MsSqlLib.Persistence
{
    public static class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context)
        {
            context.Database.Migrate();
        }
    }
}
