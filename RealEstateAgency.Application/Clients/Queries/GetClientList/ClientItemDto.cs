using AutoMapper;
using RealEstateAgency.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Clients.Queries.GetClientList
{
    public class ClientItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Client, ClientItemDto>()
                .ForMember(clientDto => clientDto.Id,
                    opt => opt.MapFrom(client => client.Id))
                .ForMember(clientDto => clientDto.Name,
                    opt => opt.MapFrom(client => client.Name))
                .ForMember(clientDto => clientDto.Surname,
                    opt => opt.MapFrom(client => client.Surname))
                .ForMember(clientDto => clientDto.Patronymic,
                    opt => opt.MapFrom(client => client.Patronymic))
                .ForMember(clientDto => clientDto.Email,
                    opt => opt.MapFrom(client => client.Email))
                .ForMember(clientDto => clientDto.Phone,
                    opt => opt.MapFrom(client => client.Phone));
        }
    }
}
