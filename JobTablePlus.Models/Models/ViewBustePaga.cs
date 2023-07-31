using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewBustePaga
{
    public int? Anno { get; set; }

    public int? Mese { get; set; }

    public int? Giorno { get; set; }

    public string? Bu { get; set; }

    public int? Idsocieta { get; set; }

    public string? Nr { get; set; }

    public string? Descrizione { get; set; }

    public string? FullName { get; set; }

    public string? DescrizioneCliente { get; set; }

    public decimal? Consuntivo { get; set; }
}
