using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateAgency.Domain.Entites;

namespace RealEstateAgency.Infrastructure.Persistence.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(agent => agent.Id);
            builder.HasIndex(agent => agent.Id).IsUnique();
            builder.Property(agent => agent.Name).HasMaxLength(250);
            builder.Property(agent => agent.Surname).HasMaxLength(250);
            builder.Property(agent => agent.Patronymic).HasMaxLength(250);
            builder.Property(agent => agent.Email).HasMaxLength(250);
            builder.Property(agent => agent.Phone).HasMaxLength(20);
        }
    }
}
