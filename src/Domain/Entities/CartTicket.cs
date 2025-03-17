namespace TicketPrimeauth.Domain.Entities;

public class CartTicket
{
    public Guid CartId { get; set; }
    public Guid TicketId { get; set; }
    public int Amount { get; set; }
    public decimal PricePerUnit { get; set; }
}
