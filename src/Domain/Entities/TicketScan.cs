namespace TicketPrimeauth.Domain.Entities;

public class TicketScan : BaseAuditableEntity<Guid>
{
    public Guid TicketId { get; set; }
    public string QrCode { get; set; } = string.Empty;
    public bool IsUsed { get; set; } = false;
    public DateTime? ExpirationTime { get; set; }
    public DateTime? ScannedAt { get; set; }
}
