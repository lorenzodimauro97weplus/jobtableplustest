using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewUsersToBu
{
    public string? Bu { get; set; }

    public int Idutente { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public string? Nominativo { get; set; }

    public string? Mail { get; set; }

    public bool? Disattivo { get; set; }
}
