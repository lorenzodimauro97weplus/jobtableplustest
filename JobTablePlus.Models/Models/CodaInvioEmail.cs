using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class CodaInvioEmail
{
    public int Id { get; set; }

    public int IdtipoMail { get; set; }

    public string Host { get; set; } = null!;

    public int Port { get; set; }

    public bool UseDefaultCredentials { get; set; }

    public string? Username { get; set; }

    public string? Pwd { get; set; }

    public bool EnableSsl { get; set; }

    public int Timeout { get; set; }

    public string To { get; set; } = null!;

    public string From { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool IsBodyHtml { get; set; }

    public string? Cc { get; set; }

    public string? Ccn { get; set; }

    public bool Inviata { get; set; }

    public DateTime? DataDiInvio { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<CodaInvioEmailAttachment> CodaInvioEmailAttachments { get; set; } = new List<CodaInvioEmailAttachment>();

    public virtual TipoEmail IdtipoMailNavigation { get; set; } = null!;
}
