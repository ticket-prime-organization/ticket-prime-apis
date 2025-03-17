using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;
using TicketPrimeauth.Infrastructure.Identity;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.ToTable("PaymentMethods");

        builder.Property(s => s.UserId)
            .IsRequired();

        builder.HasOne<CardType>()
            .WithMany()
            .HasForeignKey(pm => pm.CardTypeId);

        builder.Property(pm => pm.CardNumber)
            .IsRequired();

        builder.Property(pm => pm.ExpiryDate)
            .IsRequired();
    }
}
