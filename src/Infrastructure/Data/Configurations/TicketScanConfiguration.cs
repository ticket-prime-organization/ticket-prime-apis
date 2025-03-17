using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class TicketScanConfiguration : IEntityTypeConfiguration<TicketScan>
{
    public void Configure(EntityTypeBuilder<TicketScan> builder)
    {
        builder.ToTable("TicketScans");

        builder.HasKey(ts => ts.Id);

        builder.HasOne<Ticket>()
            .WithMany()
            .HasForeignKey(ts => ts.TicketId);

        builder.Property(ts => ts.QrCode)
            .IsRequired()
            .HasColumnType("text");
        builder.Property(ts => ts.IsUsed)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(ts => ts.ExpirationTime)
            .HasColumnType("timestamp with time zone");

        builder.Property(ts => ts.ScannedAt)
            .HasColumnType("timestamp with time zone");

        builder.HasIndex(ts => ts.TicketId);
    }
}
