using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Application.Agents.Command.CreateAgent;
using RealEstateAgency.Application.Agents.Command.DeleteAgent;
using RealEstateAgency.Application.Agents.Queries.GetAgentList;
using RealEstateAgency.Web.Models;

namespace RealEstateAgency.Web.Controllers
{
    public class AgentListController : ApiControllerBase
    {
        private readonly IMapper _mapper;

        public AgentListController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<AgentListVm>> GetAll()
        {
            var query = new GetAgentListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateAgentDto createAgentDto)
        {
            var command = _mapper.Map<CreateAgentCommand>(createAgentDto);
            var agentId = await Mediator.Send(command);

            return Ok(agentId);
        } 
        
        [HttpPut]
        public async Task<ActionResult<Guid>> Update([FromBody] UpdateAgentDto updateAgentDto)
        {
            var command = _mapper.Map<UpdateAgentDto>(updateAgentDto);
            var agentId = await Mediator.Send(command);

            return Ok(agentId);
        }

        [HttpDelete]
        public async Task<ActionResult<Guid>> Delete(Guid id)
        {
            var command = new DeleteAgentCommand()
            {
                Id = id
            };
            await Mediator.Send(command);

            return NoContent();
        }
    }
}
