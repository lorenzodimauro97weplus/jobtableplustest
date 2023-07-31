using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class TipologiaCommessaAttivitum
{
    public int Id { get; set; }

    public int? TipologiaCommessa { get; set; }

    public int? TipologiaAttivita { get; set; }
}
