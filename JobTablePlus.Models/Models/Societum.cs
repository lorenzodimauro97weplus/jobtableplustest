using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Societum
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public int? IdOldJobTable { get; set; }
}
