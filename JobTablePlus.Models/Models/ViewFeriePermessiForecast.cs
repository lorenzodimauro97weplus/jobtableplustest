using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewFeriePermessiForecast
{
    public int Idutente { get; set; }

    public decimal? Ferie { get; set; }

    public decimal? Permesso { get; set; }
}
