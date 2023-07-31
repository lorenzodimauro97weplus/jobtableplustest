using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class UtentiCommesseAttivitum
{
    public int Id { get; set; }

    public int? IdutentiCommesse { get; set; }

    public int? IdtipoAttivita { get; set; }

    public virtual TipologiaAttivitum? IdtipoAttivitaNavigation { get; set; }
}
