using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Social> Socials { get; }
    public DbSet<CardType> CardTypes { get; }
    public DbSet<PaymentMethod> PaymentMethods { get; }
    public DbSet<Performer> Performers { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
