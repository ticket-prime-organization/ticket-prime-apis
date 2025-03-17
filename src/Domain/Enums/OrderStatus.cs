namespace TicketPrimeauth.Domain.Enums;

public enum OrderStatus
{
    Pending = 1,        // Order created, awaiting payment
    Paid = 2,           // Payment received
    Processing = 3,     // Order being verified and tickets prepared
    Fulfilled = 4,      // Tickets delivered (QR code valid)
    Completed = 5,      // Event passed, order finalized
    Canceled = 6,       // Order canceled, tickets invalid
    Refunded = 7,       // Payment refunded, tickets invalid
    Failed = 8,         // Payment failed
    Expired = 9,        // Order expired before payment
    Chargeback = 10     // Payment disputed, refunded, tickets invalid
}
