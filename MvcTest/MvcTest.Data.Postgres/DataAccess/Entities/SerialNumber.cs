using System;
using System.Collections.Generic;

namespace MvcTest.Data.Postgres.DataAccess.Entities;

public partial class SerialNumber
{
    public Guid Id { get; set; }

    public string Number { get; set; } = null!;

    public virtual Machine? Machine { get; set; }
}
