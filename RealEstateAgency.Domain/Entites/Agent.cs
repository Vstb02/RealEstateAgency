namespace RealEstateAgency.Domain.Entites;

public class Agent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public int? DealShare { get; set; }
    public DateTime? Created { get; set; }
}

