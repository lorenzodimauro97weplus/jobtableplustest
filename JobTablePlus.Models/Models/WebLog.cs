using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class WebLog
{
    public string LogCurrentUser { get; set; } = null!;

    public DateTime LogDatetime { get; set; }

    public string? LogMessage { get; set; }

    public string? LogClass { get; set; }

    public string? LogMethod { get; set; }
}
