using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewEffortBuTotalNewOld
{
    public string? Bu { get; set; }

    public string? AdminGroupUsername { get; set; }

    public decimal? BilledDays { get; set; }

    public decimal? NotBilledDays { get; set; }

    public decimal? EuropeanPrjDays { get; set; }

    public decimal? HolidayJobDays { get; set; }

    public decimal? FeriePermessi { get; set; }

    public decimal? Mutua { get; set; }

    public string? UserName { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyJobName { get; set; }

    public string? Description { get; set; }

    public DateOnly? ReportDate { get; set; }

    public int IsEuropeanPrj { get; set; }

    public double? PartialDays { get; set; }

    public string? Nr { get; set; }

    public string? Descrizione { get; set; }
}
