using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class TipologiaAttivitum
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public virtual ICollection<UtentiCommesseAttivitum> UtentiCommesseAttivita { get; set; } = new List<UtentiCommesseAttivitum>();

    public virtual ICollection<UtentiCommesseTipoAttivitum> UtentiCommesseTipoAttivita { get; set; } = new List<UtentiCommesseTipoAttivitum>();
}
