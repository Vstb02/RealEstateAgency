using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Domain.Entites;
using RealEstateAgency.Infrastructure.Persistence.Configuration;

namespace RealEstateAgency.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Agent> Agents { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());

            base.OnModelCreating(builder);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
