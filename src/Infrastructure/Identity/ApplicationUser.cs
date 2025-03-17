using Microsoft.AspNetCore.Identity;
using TicketPrimeauth.Domain;
using TicketPrimeauth.Domain.Entities;

namespace TicketPrimeauth.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string? AvatarUrl { get; set; }
    public List<Social> Socials { get; set; } = [];
    public List<Performer> Performers { get; set; } = [];
    public List<PaymentMethod> PaymentMethods { get; set; } = [];
}
