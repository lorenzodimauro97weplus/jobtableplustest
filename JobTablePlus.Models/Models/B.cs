using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class B
{
    public int Idcommessa { get; set; }

    public decimal? GiorniEffettivi { get; set; }

    public decimal? OreEffettive { get; set; }

    public decimal? OreStraordinario { get; set; }

    public decimal? CostoTotaleGiornaliero { get; set; }

    public decimal? CostoTotaleStrutturaGiornaliero { get; set; }
}
