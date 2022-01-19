using MediatR;

namespace RealEstateAgency.Application.Clients.Commands.DeleteClient
{
    public class DeleteClientCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
