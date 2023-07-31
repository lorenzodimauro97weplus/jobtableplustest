using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class CodaInvioEmailAttachment
{
    public int IdcodaInvioEmail { get; set; }

    public int Idattachment { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Attachment IdattachmentNavigation { get; set; } = null!;

    public virtual CodaInvioEmail IdcodaInvioEmailNavigation { get; set; } = null!;
}
