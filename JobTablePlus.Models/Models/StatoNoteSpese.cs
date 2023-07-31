using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class StatoNoteSpese
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public virtual ICollection<NoteSpese> NoteSpeses { get; set; } = new List<NoteSpese>();
}
