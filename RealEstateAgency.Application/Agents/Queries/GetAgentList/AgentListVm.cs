using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Agents.Queries.GetAgentList
{
    public class AgentListVm
    {
        public IList<AgentItemDto> Lists { get; set; } = new List<AgentItemDto>();
    }
}
