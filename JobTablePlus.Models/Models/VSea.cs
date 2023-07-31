﻿using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VSea
{
    public string? Nr { get; set; }

    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public decimal? Tariffaoraria { get; set; }

    public DateOnly? ShortDate { get; set; }

    public decimal? Ore { get; set; }

    public string? Note { get; set; }
}
