using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Attachment
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string FileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public string? FileBase64String { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<CodaInvioEmailAttachment> CodaInvioEmailAttachments { get; set; } = new List<CodaInvioEmailAttachment>();

    public virtual ICollection<NoteSpeseAttachment> NoteSpeseAttachments { get; set; } = new List<NoteSpeseAttachment>();
}
