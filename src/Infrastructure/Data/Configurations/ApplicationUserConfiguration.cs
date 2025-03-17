using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;
using TicketPrimeauth.Infrastructure.Identity;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("AspNetUsers");

        builder.Property(u => u.AvatarUrl)
            .HasMaxLength(500)
            .IsRequired(false);

        builder.HasMany(u => u.Socials)
            .WithOne()
            .HasForeignKey(s => s.UserId);

        builder.HasMany(u => u.Performers)
            .WithOne()
            .HasForeignKey(p => p.UserId);

        builder.HasMany(u => u.PaymentMethods)
            .WithOne()
            .HasForeignKey(pm => pm.UserId);
    }
}
