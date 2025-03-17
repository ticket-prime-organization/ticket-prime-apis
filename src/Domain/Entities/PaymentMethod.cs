namespace TicketPrimeauth.Domain.Entities;

public class PaymentMethod : BaseAuditableEntity<Guid>
{
    public string UserId { get; set; } = default!;
    public short CardTypeId { get; set; }
    public string CardNumber { get; set; } = default!;
    public string ExpiryDate { get; set; } = default!;
}
