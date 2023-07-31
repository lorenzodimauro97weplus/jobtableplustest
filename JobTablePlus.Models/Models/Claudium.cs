using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Claudium
{
    public string? Description { get; set; }

    public string? Id { get; set; }

    public string? CodiceOldJobTable { get; set; }

    public string? CodiceNewJobTable { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public DateTime? Note { get; set; }

    public string? Persone { get; set; }
}
