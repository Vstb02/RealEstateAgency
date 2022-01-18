using MediatR;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Domain.Entites;

namespace RealEstateAgency.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateClientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Surname = request.Surname,
                Patronymic = request.Patronymic,
                Phone = request.Phone,
                Email = request.Email
            };

            await _context.Clients.AddAsync(client, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return client.Id;
        }
    }
}
