namespace TicketPrimeauth.Domain.Common;

public abstract class BaseAuditableEntity<TId> : BaseEntity<TId>
{
    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTimeOffset Deleted { get; set; }

    public bool DeleteFlag { get; set; }
}
