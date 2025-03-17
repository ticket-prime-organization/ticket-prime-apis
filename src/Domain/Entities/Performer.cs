namespace TicketPrimeauth.Domain.Entities;

public class Performer : BaseAuditableEntity<Guid>
{
    public string UserId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Bio { get; set; }
    public string? SocialLinks { get; set; }
}
