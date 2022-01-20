using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Application.Common.Interfaces;

namespace RealEstateAgency.Application.Clients.Queries.GetClientList
{
    public class GetClientListQueyHandler : IRequestHandler<GetClientListQuery, ClientListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetClientListQueyHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ClientListVm> Handle(GetClientListQuery request, CancellationToken cancellationToken)
        {
            var clientQuery = await _context.Clients
                .ProjectTo<ClientItemDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ClientListVm { Lists = clientQuery };
        }
    }
}
