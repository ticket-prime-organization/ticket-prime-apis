namespace TicketPrimeauth.Domain.Entities;

public class Event : BaseAuditableEntity<Guid>
{
    public Guid PerformerId { get; set; }
    public short CategoryId { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}
