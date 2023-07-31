using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VwEmailConfiguration
{
    public string? SmtpHost { get; set; }

    public int? SmtpPort { get; set; }

    public bool? SmtpDefaultCredentials { get; set; }

    public string? SmtpUser { get; set; }

    public string? SmtpPwd { get; set; }

    public bool? SmtpEnableSsl { get; set; }

    public int? SmtpTimeout { get; set; }

    public string? SmtpFrom { get; set; }

    public bool? SmtpIsBodyHtml { get; set; }
}
