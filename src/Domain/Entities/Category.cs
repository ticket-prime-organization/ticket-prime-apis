namespace TicketPrimeauth.Domain.Entities;

public class Category : BaseAuditableEntity<short>
{
    public string Name { get; set; } = default!;
    public string NormalizedName { get; set; } = default!;
}
