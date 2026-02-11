using System;
using System.Collections.Generic;

namespace MvcTest.Data.Postgres.DataAccess.Entities;

public partial class MachineAssignment
{
    public Guid Id { get; set; }

    public Guid MachineId { get; set; }

    public Guid? OwnerId { get; set; }

    public string? OwnerName { get; set; }

    public bool IsHidden { get; set; }

    public DateOnly? SellDate { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public bool IsSold { get; set; }

    public DateTime DateCreated { get; set; }

    public string? ImageUrl { get; set; }

    public string? ThumbnailUrl { get; set; }

    public string? ProofOfPurchaseUrl { get; set; }

    public string? MachineDescription { get; set; }

    public string? MachineName { get; set; }

    public bool EuDataActAccepted { get; set; }

    public virtual Machine Machine { get; set; } = null!;
}
