using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewPartialDay
{
    public int? UserId { get; set; }

    public int? Anno { get; set; }

    public int? Mese { get; set; }

    public int? WorkedDays { get; set; }

    public int? NumberOfWorkingDays { get; set; }

    public decimal? PartialDays { get; set; }
}
