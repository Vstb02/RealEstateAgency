using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Application.Common.Exceptions;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Agents.Command.UpdateAgent
{
    public class UpdateAgentCommandHandler : IRequestHandler<UpdateAgentCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAgentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateAgentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Agents.FirstOrDefaultAsync(agent =>
            agent.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Agent), request.Id);
            }

            entity.Name = request.Name;
            entity.Surname = request.Surname;
            entity.Patronymic = request.Patronymic;
            entity.DealShare = request.DealShare;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
