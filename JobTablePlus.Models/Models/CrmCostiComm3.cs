using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class CrmCostiComm3
{
    public Guid? Idordine { get; set; }

    public string? Nr { get; set; }

    public decimal? SommaOreOrdinarie { get; set; }

    public decimal? SommaOreExtra { get; set; }

    public decimal? OreTotali { get; set; }

    public decimal? SommaCostoTotale { get; set; }

    public string? StatoCommessa { get; set; }
}
