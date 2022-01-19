using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Application.Common.Exceptions;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Domain.Entites;

namespace RealEstateAgency.Application.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand>
    {
        private readonly IApplicationDbContext _context;
        public UpdateClientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Clients.FirstOrDefaultAsync(client =>
                client.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Client), request.Id);
            }

            entity.Name = request.Name;
            entity.Surname = request.Surname;
            entity.Patronymic = request.Patronymic;
            entity.Email = request.Email;
            entity.Phone = request.Phone;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
