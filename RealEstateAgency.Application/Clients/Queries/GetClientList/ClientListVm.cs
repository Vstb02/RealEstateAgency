
namespace RealEstateAgency.Application.Clients.Queries.GetClientList
{
    public class ClientListVm
    {
        public IList<ClientItemDto> Lists { get; set; } = new List<ClientItemDto>();
    }
}
