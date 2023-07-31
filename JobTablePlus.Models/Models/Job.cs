using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Job
{
    public string Id { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string State { get; set; } = null!;

    public int CustomerId { get; set; }

    public string? Description { get; set; }

    public bool Billable { get; set; }

    public int CompanyId { get; set; }

    public bool IsEuropeanPrj { get; set; }

    public bool IsHolidayJob { get; set; }

    public bool IsDescriptionMandatory { get; set; }

    public string? IdOrdineCrm { get; set; }

    public string? NumeroOrdineCrm { get; set; }

    public string? BusinessUnit { get; set; }

    public double? Rate { get; set; }
}
