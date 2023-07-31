using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VQuadratura
{
    public string? Nr { get; set; }

    public string WorkerUsername { get; set; } = null!;

    public string JobId { get; set; } = null!;

    public string? CodiceNewJobTable { get; set; }

    public int? Mesenew { get; set; }

    public int? Meseold { get; set; }

    public decimal? Totalnew { get; set; }

    public int? Totaleold { get; set; }
}
