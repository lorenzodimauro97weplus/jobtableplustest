using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class TipoEmail
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public virtual ICollection<CodaInvioEmail> CodaInvioEmails { get; set; } = new List<CodaInvioEmail>();

    public virtual ICollection<TemplateEmail> TemplateEmails { get; set; } = new List<TemplateEmail>();
}
