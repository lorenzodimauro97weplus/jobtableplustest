using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Contratti
{
    public int? Idutente { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public string? TipoContratto { get; set; }

    public int? GiorniPreavviso { get; set; }
}
