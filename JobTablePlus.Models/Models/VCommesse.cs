using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VCommesse
{
    public int Id { get; set; }

    public string? Nr { get; set; }

    public string? Nome { get; set; }

    public string? Descrizione { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public int? IdtipologiaCommessa { get; set; }

    public int? Idbu { get; set; }

    public int? Idcliente { get; set; }

    public int? IdtipologiaFatturazione { get; set; }

    public Guid? Idordine { get; set; }

    public decimal? GiorniPrevisti { get; set; }

    public decimal? RicaviPrevisti { get; set; }

    public decimal? Rate { get; set; }

    public bool? ObbligoNote { get; set; }

    public int? Status { get; set; }

    public int? Idsocieta { get; set; }

    public decimal RateOrario { get; set; }
}
