using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;
using TicketPrimeauth.Infrastructure.Identity;

namespace TicketPrimeauth.Infrastructure;

public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.ToTable("PaymentMethods");

        builder.Property(s => s.UserId)
            .IsRequired();

        builder.Property(s => s.CardTypeId)
            .IsRequired();

        builder.Property(pm => pm.CardNumber)
            .IsRequired();

        builder.Property(pm => pm.ExpiryDate)
            .IsRequired();
    }
}
