using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class PeriodsWorkFlow
{
    public int Idperiod { get; set; }

    public int PeriodIdstatus { get; set; }

    public int CreateById { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
