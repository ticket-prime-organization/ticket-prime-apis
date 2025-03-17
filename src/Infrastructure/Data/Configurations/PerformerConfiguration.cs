using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;
using TicketPrimeauth.Infrastructure.Identity;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class PerformerConfiguration : IEntityTypeConfiguration<Performer>
{
    public void Configure(EntityTypeBuilder<Performer> builder)
    {
        builder.ToTable("Performers");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.HasIndex(p => p.Name)
            .IsUnique();

        builder.Property(s => s.UserId)
            .IsRequired();

        builder.Property(p => p.Bio)
            .HasColumnType("text");

        builder.Property(p => p.SocialLinks)
            .HasColumnType("jsonb");
    }
}
