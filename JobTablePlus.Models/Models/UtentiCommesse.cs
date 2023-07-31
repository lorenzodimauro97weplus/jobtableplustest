using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class UtentiCommesse
{
    public int Id { get; set; }

    public int? Idutente { get; set; }

    public int? Idcommessa { get; set; }

    public string? SedeLavoro { get; set; }

    public bool? Status { get; set; }

    public decimal? CostoOrdinario { get; set; }

    public decimal? Tariffa { get; set; }

    public decimal? CostoStruttura { get; set; }

    public decimal? Allocazione { get; set; }
}
