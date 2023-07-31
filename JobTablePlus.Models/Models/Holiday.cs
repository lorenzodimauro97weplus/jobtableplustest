using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Holiday
{
    public string? HolidayName { get; set; }

    public DateOnly? StartDate { get; set; }

    public string? PowerAppsId { get; set; }
}
