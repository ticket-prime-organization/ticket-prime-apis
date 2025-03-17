namespace TicketPrimeauth.Domain.Entities;

public class Social : BaseAuditableEntity<Guid>
{
    public string UserId { get; set; } = default!;
    public string Link { get; set; } = default!;
}
