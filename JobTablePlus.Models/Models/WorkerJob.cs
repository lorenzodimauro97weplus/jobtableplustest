using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class WorkerJob
{
    public int Id { get; set; }

    public string JobId { get; set; } = null!;

    public string WorkerUsername { get; set; } = null!;
}
