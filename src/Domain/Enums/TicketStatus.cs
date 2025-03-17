namespace TicketPrimeauth.Domain.Enums;

public enum TicketStatus
{
    Available = 1,     // Ticket is available for purchase
    Sold = 2,          // Ticket has been purchased
    Reserved = 3,      // Ticket is held for a limited time
    Canceled = 4,      // Ticket purchase was canceled
    Refunded = 5,      // Ticket was refunded
    Expired = 6,       // Ticket is no longer valid
    Used = 7           // Ticket has been scanned and used
}


