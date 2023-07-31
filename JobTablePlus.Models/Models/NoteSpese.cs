using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class NoteSpese
{
    public int Id { get; set; }

    public int Idutente { get; set; }

    public int Idcommessa { get; set; }

    public int Idstato { get; set; }

    public int IdtipoFatturazione { get; set; }

    public string? Descrizione { get; set; }

    public decimal? Importo { get; set; }

    public DateTime? DataInizio { get; set; }

    public DateTime? DataFine { get; set; }

    public string? MeseRiferimento { get; set; }

    public string? AnnoRiferimento { get; set; }

    public string? Note { get; set; }

    public bool? IsAnticipato { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual StatoNoteSpese IdstatoNavigation { get; set; } = null!;

    public virtual NoteSpeseTipoFatturazione IdtipoFatturazioneNavigation { get; set; } = null!;

    public virtual Utenti IdutenteNavigation { get; set; } = null!;

    public virtual ICollection<NoteSpeseAttachment> NoteSpeseAttachments { get; set; } = new List<NoteSpeseAttachment>();
}
