using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Domain.Entites;

namespace RealEstateAgency.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Agent> Agents { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
