using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class User
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int UserRole { get; set; }
}
