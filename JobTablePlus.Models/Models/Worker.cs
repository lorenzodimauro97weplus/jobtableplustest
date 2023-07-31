using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Worker
{
    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FiscalCode { get; set; } = null!;

    public int CompanyId { get; set; }

    public bool Fired { get; set; }

    public string? CorporatePhone { get; set; }

    public string Username { get; set; } = null!;

    public string? Email { get; set; }

    public int? WorkingHours { get; set; }

    public int? WorkingDays { get; set; }

    public int? CreditHours { get; set; }

    public string? AdminGroupUsername { get; set; }

    public string? LegacyEmail { get; set; }
}
