namespace RealEstateAgency.Domain.Entites;

public class Client
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Patronymic { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime Created { get; set; }
}

