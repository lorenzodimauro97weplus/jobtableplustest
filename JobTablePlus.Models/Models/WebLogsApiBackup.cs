using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class WebLogsApiBackup
{
    public int Id { get; set; }

    public string? LogJson { get; set; }

    public string? LogClass { get; set; }

    public string? LogMethod { get; set; }

    public DateTime? LogDatetime { get; set; }
}
