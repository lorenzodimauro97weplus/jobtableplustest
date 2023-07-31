using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class NoteSpeseAttachment
{
    public int AttachementId { get; set; }

    public int NoteSpeseId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual Attachment Attachement { get; set; } = null!;

    public virtual NoteSpese NoteSpese { get; set; } = null!;
}
