using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewGetNumDaysWorking
{
    public DateTime? StartDate { get; set; }

    public int? Anno { get; set; }

    public int? Mese { get; set; }

    public int? NumberOfWorkingDays { get; set; }
}
