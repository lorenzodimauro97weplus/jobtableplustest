using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class UtentiBackup
{
    public int Id { get; set; }

    public DateTime SysStart { get; set; }

    public DateTime SysEnd { get; set; }

    public string? LoginName { get; set; }

    public string? Email { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public string? Badge { get; set; }

    public decimal? CostoOrdinario { get; set; }

    public decimal? CostoStraordinario { get; set; }

    public decimal? CostoStruttura { get; set; }

    public int? Idsocieta { get; set; }

    public int? Idbu { get; set; }

    public int? Idruolo { get; set; }

    public int? Idmanager { get; set; }

    public decimal? OreGiorno { get; set; }

    public decimal? QtyGiorni { get; set; }
}
