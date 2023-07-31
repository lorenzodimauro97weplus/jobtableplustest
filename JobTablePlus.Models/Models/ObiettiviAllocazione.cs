using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ObiettiviAllocazione
{
    public int IdObiettivo { get; set; }

    public int Anno { get; set; }

    public int Mese { get; set; }

    public int NumGiornateFatturabili { get; set; }

    public DateTime? DatInsRec { get; set; }

    public DateTime? DatModRec { get; set; }
}
