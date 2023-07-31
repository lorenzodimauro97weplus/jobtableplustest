using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Festivity
{
    public int Id { get; set; }

    public DateOnly Day { get; set; }

    public string Name { get; set; } = null!;

    public string? Worker { get; set; }
}
