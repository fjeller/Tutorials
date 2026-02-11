using System;
using System.Collections.Generic;

namespace MvcTest.Data.Postgres.DataAccess.Entities;

public partial class Machine
{
    public Guid Id { get; set; }

    public Guid? SerialNumberId { get; set; }

    public string Status { get; set; } = null!;

    public Guid? ApprovedById { get; set; }

    public string? ApprovedByName { get; set; }

    public virtual ICollection<MachineAssignment> MachineAssignments { get; set; } = new List<MachineAssignment>();

    public virtual SerialNumber? SerialNumber { get; set; }
}
