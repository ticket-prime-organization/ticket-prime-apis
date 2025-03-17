namespace TicketPrimeauth.Domain.Entities;

public class CardType : BaseAuditableEntity<short>
{
    public string Name { get; set; } = default!;
    public string NormalizedName { get; set; } = default!;
}
