using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RealEstateAgency.Web.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class ApiControllerBase : ControllerBase
    {
        private ISender _mediatr = null!;

        protected ISender Mediator => _mediatr ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
