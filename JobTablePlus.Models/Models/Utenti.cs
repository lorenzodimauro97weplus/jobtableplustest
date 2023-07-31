using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Utenti
{
    public int Id { get; set; }

    public int? Idsocieta { get; set; }

    public int? Idbu { get; set; }

    public int? Idruolo { get; set; }

    public int? Idmanager { get; set; }

    public string? LoginName { get; set; }

    public string? Email { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public string? Badge { get; set; }

    public decimal? OreGiorno { get; set; }

    public decimal? QtyGiorni { get; set; }

    public int? CreditHours { get; set; }

    public bool? Disattivo { get; set; }

    public DateOnly? DataDiNascita { get; set; }

    public virtual ICollection<NoteSpese> NoteSpeses { get; set; } = new List<NoteSpese>();

    public virtual ICollection<SchedaEsperienze> SchedaEsperienzes { get; set; } = new List<SchedaEsperienze>();
}
