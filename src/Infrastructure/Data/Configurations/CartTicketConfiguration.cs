using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class CartTicketConfiguration : IEntityTypeConfiguration<CartTicket>
{
    public void Configure(EntityTypeBuilder<CartTicket> builder)
    {
        builder.ToTable("CartTickets");

        builder.HasKey(ct => new { ct.CartId, ct.TicketId });

        builder.HasOne<Cart>()
            .WithMany()
            .HasForeignKey(ct => ct.CartId);

        builder.HasOne<Ticket>()
            .WithMany()
            .HasForeignKey(ct => ct.TicketId);

        builder.Property(ct => ct.Amount)
            .IsRequired()
            .HasDefaultValue(1)
            .HasComment("Must be greater than 0");

        builder.Property(ct => ct.PricePerUnit)
            .IsRequired()
            .HasColumnType("decimal(10,2)")
            .HasComment("Must be greater than or equal 0");

        builder.HasIndex(ct => ct.CartId);
        builder.HasIndex(ct => ct.TicketId);
    }
}
