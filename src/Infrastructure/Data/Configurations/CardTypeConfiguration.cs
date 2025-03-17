using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure;

public class CardTypeConfiguration : IEntityTypeConfiguration<CardType>
{
    public void Configure(EntityTypeBuilder<CardType> builder)
    {
        builder.ToTable("CardTypes");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(c => c.NormalizedName)
            .HasMaxLength(255)
            .IsRequired();
    }
}
