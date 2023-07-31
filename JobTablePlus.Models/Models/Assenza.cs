using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Assenza
{
    public int Id { get; set; }

    public int? Idutente { get; set; }

    public int? Idapprovatore { get; set; }

    public int? IdtipologiaAssenza { get; set; }

    public decimal? Value { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? Costo { get; set; }

    public DateTime DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public string? Descrizione { get; set; }

    public bool? RichiestaForzata { get; set; }

    public int? Stato { get; set; }

    public DateTime? TimeStampInserimento { get; set; }

    public DateTime? TimeStampApprovazione { get; set; }
}
