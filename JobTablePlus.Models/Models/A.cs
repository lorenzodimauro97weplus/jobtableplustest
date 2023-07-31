using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class A
{
    public int Idcommessa { get; set; }

    public int Idutente { get; set; }

    public DateOnly? ShortDate { get; set; }

    public decimal Valore { get; set; }

    public decimal ExtraHours { get; set; }

    public decimal? CostoOrdinario { get; set; }

    public decimal? CostoTotaleStrutturaGiornaliero { get; set; }
}
