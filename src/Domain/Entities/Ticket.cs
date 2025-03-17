using TicketPrimeauth.Domain.Enums;

namespace TicketPrimeauth.Domain.Entities;

public class Ticket : BaseAuditableEntity<Guid>
{
    public string Code { get; set; } = default!;
    public string UserId { get; set; } = default!;
    public Guid? OrderId { get; set; }
    public Guid VenueId { get; set; }
    public Guid EventId { get; set; }
    public TicketStatus TicketStatus { get; set; }
    public TicketType TicketType { get; set; }
    public string SeatNumber { get; set; } = default!;
    public decimal Price { get; set; }
}
