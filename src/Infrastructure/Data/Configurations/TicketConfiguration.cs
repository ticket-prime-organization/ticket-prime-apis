using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.ToTable("Tickets");

        builder.HasKey(t => t.Id);

        builder.HasIndex(t => t.Code)
            .IsUnique();

        builder.Property(t => t.UserId)
            .IsRequired()
            .HasColumnType("text");

        // builder.HasOne<Order>()
        //     .WithMany()
        //     .HasForeignKey(t => t.OrderId);

        builder.HasOne<Venue>()
            .WithMany()
            .HasForeignKey(t => t.VenueId);

        builder.HasOne<Event>()
            .WithMany()
            .HasForeignKey(t => t.EventId);

        builder.Property(t => t.TicketStatus)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(t => t.TicketType)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(t => t.SeatNumber)
            .IsRequired(false)
            .HasMaxLength(10);

        builder.Property(t => t.Price)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.HasIndex(t => t.UserId);
        builder.HasIndex(t => t.OrderId);
        builder.HasIndex(t => t.VenueId);
        builder.HasIndex(t => t.TicketStatus);
    }
}
