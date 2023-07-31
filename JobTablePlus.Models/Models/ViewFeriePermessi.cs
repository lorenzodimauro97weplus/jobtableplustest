using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewFeriePermessi
{
    public string? Bu { get; set; }

    public int TipoAssenza { get; set; }

    public string? Tipologia { get; set; }

    public int Idutente { get; set; }

    public string? Richiedente { get; set; }

    public string? Mail { get; set; }

    public decimal? OreRichieste { get; set; }

    public string? Stato { get; set; }

    public DateTime DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public string? Motivorichiesta { get; set; }

    public int? StatoRic { get; set; }

    public string AssenzaOdierna { get; set; } = null!;

    public int Forecast { get; set; }
}
