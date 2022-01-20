using MediatR;

namespace RealEstateAgency.Application.Agents.Command.CreateAgent
{
    public class CreateAgentCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int DealShare { get; set; }
    }
}
