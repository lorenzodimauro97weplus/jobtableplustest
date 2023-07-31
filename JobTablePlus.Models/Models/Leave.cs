using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Leave
{
    public string? Title { get; set; }

    public string? Detail { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? LeaveType { get; set; }

    public string? Requester { get; set; }

    public string? Approver { get; set; }

    public string? Status { get; set; }

    public string? LeaveId { get; set; }

    public string PowerAppsId { get; set; } = null!;
}
