using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Agents.Command.DeleteAgent
{
    public class DeleteAgentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
