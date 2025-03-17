namespace TicketPrimeauth.Domain.Entities;

public class Cart
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = default!;
}
