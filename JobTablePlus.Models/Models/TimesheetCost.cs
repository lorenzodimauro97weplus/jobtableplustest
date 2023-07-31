using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class TimesheetCost
{
    public int Id { get; set; }

    public int? IdutentiCommesse { get; set; }

    public DateOnly? ShortDate { get; set; }

    public decimal? Valore { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Ricavo { get; set; }
}
