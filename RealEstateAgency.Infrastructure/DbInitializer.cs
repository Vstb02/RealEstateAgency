using RealEstateAgency.Infrastructure.Persistence;

namespace RealEstateAgency.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
