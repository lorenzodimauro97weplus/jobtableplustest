using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class Ambito
{
    public int Id { get; set; }

    public string? Descrizione { get; set; }

    public string? Note { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
