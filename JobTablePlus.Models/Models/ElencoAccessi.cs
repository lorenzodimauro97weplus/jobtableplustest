using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ElencoAccessi
{
    public int Id { get; set; }

    public DateTime? DataLogin { get; set; }

    public int? Idutente { get; set; }
}
