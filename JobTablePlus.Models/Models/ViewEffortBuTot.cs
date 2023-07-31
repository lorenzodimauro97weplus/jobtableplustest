using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewEffortBuTot
{
    public int? Anno { get; set; }

    public int? Mese { get; set; }

    public int? Idsocieta { get; set; }

    public string CompanyName { get; set; } = null!;

    public int? Idbu { get; set; }

    public string? BuName { get; set; }

    public int? Idmanager { get; set; }

    public string? BuManager { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public int FullPartTime { get; set; }

    public string? CodCommessa { get; set; }

    public string? Description { get; set; }

    public DateOnly? ReportDate { get; set; }

    public DateTime? InizioMese { get; set; }

    public decimal? BilledDays { get; set; }

    public decimal? NotBilledDays { get; set; }

    public decimal? EuropeanPrjDays { get; set; }

    public decimal? HolidayJobDays { get; set; }

    public decimal? FeriePermessi { get; set; }

    public decimal? Mutua { get; set; }

    public int IsEuropeanPrj { get; set; }

    public decimal? PartialDays { get; set; }

    public string? NomeRisorsa { get; set; }
}
