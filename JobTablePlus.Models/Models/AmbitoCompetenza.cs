using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class AmbitoCompetenza
{
    public int Id { get; set; }

    public int Idambito { get; set; }

    public int Idcompetenza { get; set; }

    public string? Note { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Competenza IdcompetenzaNavigation { get; set; } = null!;

    public virtual ICollection<SchedaDettaglioEsperienze> SchedaDettaglioEsperienzes { get; set; } = new List<SchedaDettaglioEsperienze>();
}
