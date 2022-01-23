using AutoMapper;
using RealEstateAgency.Application.Clients.Commands.UpdateClient;
using RealEstateAgency.Application.Common.Mappings;

namespace RealEstateAgency.Web.Models
{
    public class UpdateClientDto : IMapFrom<UpdateClientCommand>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateClientDto, UpdateClientCommand>()
                .ForMember(clientCommand => clientCommand.Id,
                    opt => opt.MapFrom(clientDto => clientDto.Id))
                .ForMember(clientCommand => clientCommand.Name,
                    opt => opt.MapFrom(clientDto => clientDto.Name))
                .ForMember(clientCommand => clientCommand.Surname,
                    opt => opt.MapFrom(clientDto => clientDto.Surname))
                .ForMember(clientCommand => clientCommand.Patronymic,
                    opt => opt.MapFrom(clientDto => clientDto.Patronymic))
                .ForMember(clientCommand => clientCommand.Phone,
                    opt => opt.MapFrom(clientDto => clientDto.Phone))
                .ForMember(clientCommand => clientCommand.Email,
                    opt => opt.MapFrom(clientDto => clientDto.Email));
        }
    }
}
