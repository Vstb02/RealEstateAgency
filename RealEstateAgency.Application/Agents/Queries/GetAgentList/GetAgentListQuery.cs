using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Agents.Queries.GetAgentList
{
    public class GetAgentListQuery : IRequest<AgentListVm>
    {
    }
}
