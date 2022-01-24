using AutoMapper;
using RealEstateAgency.Application.Agents.Command.UpdateAgent;
using RealEstateAgency.Application.Common.Mappings;

namespace RealEstateAgency.Web.Models
{
    public class UpdateAgentDto : IMapFrom<UpdateAgentCommand>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int DealShare { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateAgentDto, UpdateAgentCommand>()
                .ForMember(clientCommand => clientCommand.Id,
                    opt => opt.MapFrom(clientDto => clientDto.Id))
                .ForMember(clientCommand => clientCommand.Name,
                    opt => opt.MapFrom(clientDto => clientDto.Name))
                .ForMember(clientCommand => clientCommand.Surname,
                    opt => opt.MapFrom(clientDto => clientDto.Surname))
                .ForMember(clientCommand => clientCommand.Patronymic,
                    opt => opt.MapFrom(clientDto => clientDto.Patronymic))
                .ForMember(clientCommand => clientCommand.DealShare,
                    opt => opt.MapFrom(clientDto => clientDto.DealShare));
        }
    }
}
