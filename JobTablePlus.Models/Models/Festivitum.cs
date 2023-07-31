using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Festivitum
{
    public int Id { get; set; }

    public DateTime Data { get; set; }

    public string? Descrizione { get; set; }
}
