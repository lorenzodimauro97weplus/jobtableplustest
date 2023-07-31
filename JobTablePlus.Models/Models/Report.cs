using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Report
{
    public DateOnly ReportDate { get; set; }

    public string JobId { get; set; } = null!;

    public string WorkerUsername { get; set; } = null!;

    public string? Description { get; set; }

    public int? Hours { get; set; }

    public int ActivityId { get; set; }

    public string AdminExtraHoursId { get; set; } = null!;

    public int? ExtraHours { get; set; }

    public bool? Billable { get; set; }

    public string? Text { get; set; }

    public bool? ExtraHoursValidator { get; set; }

    public int? ExtraHoursType { get; set; }
}
