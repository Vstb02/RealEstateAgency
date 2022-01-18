using MediatR;
using RealEstateAgency.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency.Application.Clients.Commands.DeleteClient
{
    public class DeleteClientCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
