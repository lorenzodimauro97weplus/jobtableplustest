using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class SchedaEsperienze
{
    public int Id { get; set; }

    public int Idcommessa { get; set; }

    public int? Idutente { get; set; }

    public int? Idstato { get; set; }

    public string? Descrizione { get; set; }

    public string? NoteAmministrazione { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual StatoSchedaEsperienze? IdstatoNavigation { get; set; }

    public virtual Utenti? IdutenteNavigation { get; set; }

    public virtual ICollection<SchedaDettaglioEsperienze> SchedaDettaglioEsperienzes { get; set; } = new List<SchedaDettaglioEsperienze>();
}
