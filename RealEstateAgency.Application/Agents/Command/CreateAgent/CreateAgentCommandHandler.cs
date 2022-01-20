using MediatR;
using RealEstateAgency.Application.Common.Interfaces;
using RealEstateAgency.Domain.Entites;

namespace RealEstateAgency.Application.Agents.Command.CreateAgent
{
    public class CreateAgentCommandHandler : IRequestHandler<CreateAgentCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateAgentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateAgentCommand request, CancellationToken cancellationToken)
        {
            var agent = new Agent
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Surname = request.Surname,
                Patronymic = request.Patronymic,
                DealShare = request.DealShare,
                Created = DateTime.Now,
            };

            await _context.Agents.AddAsync(agent, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return agent.Id;
        }
    }
}
