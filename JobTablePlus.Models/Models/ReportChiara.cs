using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ReportChiara
{
    public string? CodiceCommessa { get; set; }

    public string? DescrizioneCommessa { get; set; }

    public DateTime? DataInizioCommessa { get; set; }

    public DateTime? DataFineCommessa { get; set; }

    public string? BuRisorsa { get; set; }

    public string? Risorsa { get; set; }

    public DateOnly? Data { get; set; }

    public decimal? Consuntivo { get; set; }

    public decimal? Straordinario { get; set; }
}
