using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class UtentiDaCreare
{
    public int Id { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public string? Department { get; set; }

    public string? Company { get; set; }

    public bool? Internal { get; set; }

    public string? SpecialGroups { get; set; }

    public string? CreatorEmail { get; set; }

    public int CreationAttemptNumber { get; set; }
}
