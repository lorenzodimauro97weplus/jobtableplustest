using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Supplier { get; set; }
}
