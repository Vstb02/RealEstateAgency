using MediatR;
using RealEstateAgency.Application.Common.Exceptions;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Agents.Command.DeleteAgent
{
    public class DeleteAgentCommandHandler : IRequestHandler<DeleteAgentCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAgentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteAgentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Agents.FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Client), request.Id);
            }

            _context.Agents.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
