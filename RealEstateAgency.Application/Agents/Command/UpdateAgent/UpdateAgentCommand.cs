using MediatR;

namespace RealEstateAgency.Application.Agents.Command.UpdateAgent
{
    public class UpdateAgentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int DealShare { get; set; }
    }
}
