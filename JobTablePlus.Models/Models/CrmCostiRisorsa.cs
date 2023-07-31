using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class CrmCostiRisorsa
{
    public int? Idutente { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public int? Idbu { get; set; }

    public DateOnly? ShortDate { get; set; }

    public string? Nr { get; set; }

    public string? NomeCommessa { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoStruttura { get; set; }
}
