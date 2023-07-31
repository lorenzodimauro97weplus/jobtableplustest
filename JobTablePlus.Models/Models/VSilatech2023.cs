using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VSilatech2023
{
    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public DateOnly? ShortDate { get; set; }

    public decimal? Ore { get; set; }

    public decimal? Tariffa { get; set; }

    public string? Note { get; set; }
}
