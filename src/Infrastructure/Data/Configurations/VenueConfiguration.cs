using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.ToTable("Venues");

        builder.HasKey(v => v.Id);

        builder.HasOne<Event>()
            .WithMany()
            .HasForeignKey(v => v.EventId);

        builder.Property(v => v.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(v => v.StartAt)
            .IsRequired()
            .HasColumnType("timestamp with time zone");

        builder.Property(v => v.EndAt)
            .IsRequired()
            .HasColumnType("timestamp with time zone");

        builder.Property(v => v.TotalSeats)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(v => v.AvailableSeats)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(v => v.TicketMap)
            .IsRequired()
            .HasColumnType("jsonb");

        builder.HasIndex(v => v.EventId);
        builder.HasIndex(v => v.StartAt);
    }
}
