using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

/// <summary>
/// I gruppi speciali che possono essere assegnati alle utenze su AD Locale
/// </summary>
public partial class UserLocalAdgroup
{
    public int Id { get; set; }

    public string Group { get; set; } = null!;
}
