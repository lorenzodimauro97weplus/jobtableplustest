using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class EmailRichiesteAssenze
{
    public Guid GuidRichiesta { get; set; }

    public int? Idrichiesta { get; set; }

    public string? Destinatario { get; set; }

    public string? TestoMail { get; set; }

    public string? OggettoMail { get; set; }

    public DateTime? DataInvio { get; set; }
}
