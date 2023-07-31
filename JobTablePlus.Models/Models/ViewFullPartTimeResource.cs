using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class ViewFullPartTimeResource
{
    public int Id { get; set; }

    public string? LoginName { get; set; }

    public decimal? FullPartTime { get; set; }
}
