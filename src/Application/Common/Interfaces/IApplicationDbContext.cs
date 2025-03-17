using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Social> Socials { get; }
    public DbSet<CardType> CardTypes { get; }
    public DbSet<PaymentMethod> PaymentMethods { get; }
    public DbSet<Performer> Performers { get; }
    public DbSet<Category> Categories { get; }
    public DbSet<Event> Events { get; }
    public DbSet<Venue> Venues { get; }
    public DbSet<Ticket> Tickets { get; }
    public DbSet<TicketScan> TicketScans { get; }
    public DbSet<Cart> Carts { get; }
    public DbSet<CartTicket> CartTickets { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
