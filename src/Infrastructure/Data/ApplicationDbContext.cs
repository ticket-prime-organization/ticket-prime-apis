using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketPrimeauth.Application.Common.Interfaces;
using TicketPrimeauth.Domain;
using TicketPrimeauth.Domain.Entities;
using TicketPrimeauth.Infrastructure.Identity;

namespace TicketPrimeauth.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public DbSet<Social> Socials => Set<Social>();
    public DbSet<CardType> CardTypes => Set<CardType>();
    public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
    public DbSet<Performer> Performers => Set<Performer>();
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
