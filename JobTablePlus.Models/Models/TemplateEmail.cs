using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class TemplateEmail
{
    public int Id { get; set; }

    public int? IdtipoEmail { get; set; }

    public string? TemplateSubject { get; set; }

    public string? TemplateBody { get; set; }

    public virtual TipoEmail? IdtipoEmailNavigation { get; set; }
}
