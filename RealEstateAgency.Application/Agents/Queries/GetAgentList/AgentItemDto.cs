using AutoMapper;
using RealEstateAgency.Application.Common.Mappings;
using RealEstateAgency.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Agents.Queries.GetAgentList
{
    public class AgentItemDto : IMapFrom<Agent>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int DealShare { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Agent, AgentItemDto>()
                .ForMember(agentDto => agentDto.Id,
                    opt => opt.MapFrom(agent => agent.Id))
                .ForMember(agentDto => agentDto.Name,
                    opt => opt.MapFrom(agent => agent.Name))
                .ForMember(agentDto => agentDto.Surname,
                    opt => opt.MapFrom(agent => agent.Surname))
                .ForMember(agentDto => agentDto.Patronymic,
                    opt => opt.MapFrom(agent => agent.Patronymic))
                .ForMember(agentDto => agentDto.DealShare,
                    opt => opt.MapFrom(agent => agent.DealShare));
        }
    }
}
