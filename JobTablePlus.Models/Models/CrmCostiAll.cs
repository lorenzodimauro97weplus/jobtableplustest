using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class CrmCostiAll
{
    public Guid? Idordine { get; set; }

    public string? Nr { get; set; }

    public string? Descrizione { get; set; }

    public string? Bu { get; set; }

    public decimal? SommaOreOrdinarie { get; set; }

    public decimal? SommaOreExtra { get; set; }

    public decimal? OreTotali { get; set; }

    public decimal? SommaCostoTotale { get; set; }

    public string? StatoCommessa { get; set; }
}
