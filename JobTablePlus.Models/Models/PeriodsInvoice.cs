using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class PeriodsInvoice
{
    public int Id { get; set; }

    public int Idperiod { get; set; }

    public int IdutenteCommesseAttivita { get; set; }

    public string? NrCommessa { get; set; }

    public string? NomeCommessa { get; set; }

    public int? IdtipologiaAttivita { get; set; }

    public string? TipologiaAttivita { get; set; }

    public int? Idbu { get; set; }

    public string? Bu { get; set; }

    public int? Idcliente { get; set; }

    public string? Cliente { get; set; }

    public int? IdtipologiaFatturazione { get; set; }

    public string? TipologiaFatturazione { get; set; }

    public Guid? Idordine { get; set; }

    public int Idsocieta { get; set; }

    public int Idrisorsa { get; set; }

    public string? Risorsa { get; set; }

    public decimal? OreOrdinarie { get; set; }

    public decimal? OreStraordinarie { get; set; }

    public decimal? Tariffa { get; set; }

    public decimal? TrueOreOrdinarie { get; set; }

    public decimal? TrueOreStraordinarie { get; set; }

    public decimal? TrueTariffaOreOrdinarie { get; set; }

    public decimal? TrueTariffaOreStraordinarie { get; set; }

    public decimal? Totale { get; set; }

    public string? CrmInvoiceNumber { get; set; }

    public int CreateById { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public int UpdateById { get; set; }

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public int LastInvoiceIdstatus { get; set; }

    public string? Commenti { get; set; }
}
