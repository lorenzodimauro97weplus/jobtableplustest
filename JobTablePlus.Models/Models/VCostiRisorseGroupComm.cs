using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VCostiRisorseGroupComm
{
    public string? Descrizione { get; set; }

    public string? Risorsa { get; set; }

    public string? Nr { get; set; }

    public string? Nome { get; set; }

    public int? Anno { get; set; }

    public int? Mese { get; set; }

    public decimal? Ore { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoStru { get; set; }

    public decimal? CostoCompl { get; set; }
}
