using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class SchedaDettaglioEsperienze
{
    public int Id { get; set; }

    public int IdschedaEsperienza { get; set; }

    public int? IdambitoCompetenza { get; set; }

    public int? IntervalloDiConfidenza { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AmbitoCompetenza? IdambitoCompetenzaNavigation { get; set; }

    public virtual SchedaEsperienze IdschedaEsperienzaNavigation { get; set; } = null!;
}
