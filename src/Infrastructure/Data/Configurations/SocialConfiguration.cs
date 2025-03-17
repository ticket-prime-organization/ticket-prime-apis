using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketPrimeauth.Domain.Entities;
using TicketPrimeauth.Infrastructure.Identity;

namespace TicketPrimeauth.Infrastructure.Data.Configurations;

public class SocialConfiguration : IEntityTypeConfiguration<Social>
{
    public void Configure(EntityTypeBuilder<Social> builder)
    {
        builder.ToTable("Socials");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.UserId)
            .IsRequired();

        builder.Property(s => s.Link)
            .IsRequired()
            .HasMaxLength(500);
    }
}
