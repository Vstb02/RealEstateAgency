using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Application.Clients.Queries.GetClientList;

namespace RealEstateAgency.Web.Controllers
{
    public class ClientListController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ClientListVm>> GetAll()
        {
            var query = new GetClientListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
