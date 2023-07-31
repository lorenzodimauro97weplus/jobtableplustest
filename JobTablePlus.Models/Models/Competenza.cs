using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Competenza
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public string? Note { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AmbitoCompetenza> AmbitoCompetenzas { get; set; } = new List<AmbitoCompetenza>();
}
