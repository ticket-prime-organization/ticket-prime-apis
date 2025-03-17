using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable("Events");

        builder.HasKey(e => e.Id);

        builder.HasOne<Performer>()
            .WithMany()
            .HasForeignKey(e => e.PerformerId);

        builder.HasOne<Category>()
            .WithMany()
            .HasForeignKey(e => e.CategoryId);

        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Description)
            .IsRequired()
            .HasColumnType("text");

        builder.HasIndex(e => e.PerformerId);
        builder.HasIndex(e => e.CategoryId);
    }
}
