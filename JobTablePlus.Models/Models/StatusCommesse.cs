using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class StatusCommesse
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public int? CodiceStatus { get; set; }
}
