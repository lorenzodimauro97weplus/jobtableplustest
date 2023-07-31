using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class JobActivity
{
    public string JobId { get; set; } = null!;

    public int ActivityId { get; set; }
}
