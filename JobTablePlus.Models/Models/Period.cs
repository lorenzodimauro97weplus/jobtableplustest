using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Period
{
    public int Id { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }

    public int Idsocieta { get; set; }

    public int CreateById { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public int UpdateById { get; set; }

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public int LastPeriodIdstatus { get; set; }
}
