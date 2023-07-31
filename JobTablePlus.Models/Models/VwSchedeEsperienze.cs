using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VwSchedeEsperienze
{
    public int Id { get; set; }

    public int Idcommessa { get; set; }

    public int? Idutente { get; set; }

    public int Idcliente { get; set; }

    public int? Idstato { get; set; }

    public string? Stato { get; set; }

    public string? Commessa { get; set; }

    public string? Descrizione { get; set; }

    public string? NoteAmministrazione { get; set; }

    public string? Cliente { get; set; }

    public string? NomeUtente { get; set; }

    public string? CognomeUtente { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }
}
