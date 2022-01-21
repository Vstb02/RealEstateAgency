using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Application.Clients.Commands.CreateClient;
using RealEstateAgency.Application.Clients.Commands.DeleteClient;
using RealEstateAgency.Application.Clients.Commands.UpdateClient;
using RealEstateAgency.Application.Clients.Queries.GetClientList;
using RealEstateAgency.Domain.Entites;
using RealEstateAgency.Web.Models;

namespace RealEstateAgency.Web.Controllers
{
    public class ClientListController : ApiControllerBase
    {
        private readonly IMapper _mapper;

        public ClientListController(IMapper mapper)
        { 
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ClientListVm>> GetAll()
        {
            var query = new GetClientListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateClientDto createClientDto)
        {
            var command = _mapper.Map<CreateClientCommand>(createClientDto);
            var clientId = await Mediator.Send(command);
            return Ok(clientId);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Update([FromBody] UpdateClientDto updateClientDto)
        {
            var command = _mapper.Map<UpdateClientCommand>(updateClientDto);
            await Mediator.Send(command);
            return NoContent();
        }
        public async Task<ActionResult<Guid>> Update(Guid Id)
        {
            var command = new DeleteClientCommand()
            {
                Id = Id
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
