using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Clienti
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public string? Vatnumber { get; set; }

    public int? IdOldJobTable { get; set; }
}
