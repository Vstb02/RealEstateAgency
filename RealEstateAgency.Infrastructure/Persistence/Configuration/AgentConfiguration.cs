using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateAgency.Domain.Entites;

namespace RealEstateAgency.Infrastructure.Persistence.Configuration
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasKey(agent => agent.Id);
            builder.HasIndex(agent => agent.Id).IsUnique();
            builder.Property(agent => agent.Name).HasMaxLength(250);
            builder.Property(agent => agent.Surname).HasMaxLength(250);
            builder.Property(agent => agent.Patronymic).HasMaxLength(250);
            builder.Property(agent => agent.DealShare).HasMaxLength(3);
        }
    }
}
