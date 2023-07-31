using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class UtentiCostiBackup
{
    public int Id { get; set; }

    public int? Idutente { get; set; }

    public decimal? CostoOrdinario { get; set; }

    public decimal? CostoSmartWorking { get; set; }

    public decimal? CostoMutua { get; set; }

    public decimal? CostoFeriePermessi { get; set; }

    public decimal? CostoStruttura { get; set; }

    public DateOnly? ValidFrom { get; set; }

    public DateOnly? ValidTo { get; set; }
}
