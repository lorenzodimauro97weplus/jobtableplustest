using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class PeriodsInvoicesWorkFlow
{
    public int Id { get; set; }

    public int Idperiod { get; set; }

    public int IdutenteCommesseAttivita { get; set; }

    public int InvoiceIdstatus { get; set; }

    public int CreateById { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
