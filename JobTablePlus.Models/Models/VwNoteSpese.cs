using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VwNoteSpese
{
    public int Id { get; set; }

    public int Idutente { get; set; }

    public int Idcommessa { get; set; }

    public int Idstato { get; set; }

    public int IdtipoFatturazione { get; set; }

    public string? Stato { get; set; }

    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public string? Descrizione { get; set; }

    public decimal? Importo { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public string? MeseRiferimento { get; set; }

    public string? AnnoRiferimento { get; set; }

    public string? Note { get; set; }

    public string? Commessa { get; set; }

    public string? TipoFatturazione { get; set; }

    public bool? IsAnticipato { get; set; }
}
