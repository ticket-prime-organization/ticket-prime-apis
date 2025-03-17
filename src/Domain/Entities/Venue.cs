namespace TicketPrimeauth.Domain.Entities;

public class Venue : BaseAuditableEntity<Guid>
{
    public Guid EventId { get; set; }
    public string Name { get; set; } = default!;
    public DateTimeOffset StartAt { get; set; }
    public DateTimeOffset EndAt { get; set; }
    public int TotalSeats { get; set; }
    public int AvailableSeats { get; set; }
    public string TicketMap { get; set; } = default!;
}
