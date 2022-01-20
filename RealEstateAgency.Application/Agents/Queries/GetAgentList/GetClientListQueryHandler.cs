using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Application.Common.Interfaces;

namespace RealEstateAgency.Application.Agents.Queries.GetAgentList
{
    public class GetClientListQueryHandler : IRequestHandler<GetAgentListQuery, AgentListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetClientListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AgentListVm> Handle(GetAgentListQuery request, CancellationToken cancellationToken)
        {
            var agentQuery = await _context.Agents
                .ProjectTo<AgentItemDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new AgentListVm { Lists = agentQuery };
        }
    }
}
