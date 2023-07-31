using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class StatoSchedaEsperienze
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public virtual ICollection<SchedaEsperienze> SchedaEsperienzes { get; set; } = new List<SchedaEsperienze>();
}
