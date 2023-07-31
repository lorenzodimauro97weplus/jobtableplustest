using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Timesheet
{
    public int Id { get; set; }

    public int IdutentiCommesseAttivita { get; set; }

    public DateOnly? ShortDate { get; set; }

    public decimal? Valore { get; set; }

    public int? IdtipologiaConsuntivo { get; set; }

    public string? Note { get; set; }

    public decimal? ExtraHours { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Tariffa { get; set; }

    public byte? ExtraValidate { get; set; }

    public TimeOnly? OrarioIn { get; set; }

    public TimeOnly? OrarioOut { get; set; }
}
