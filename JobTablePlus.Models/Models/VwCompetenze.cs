using System;
using System.Collections.Generic;

namespace JobTablePlus.Models.Models;

public partial class VwCompetenze
{
    public int Id { get; set; }

    public int Idambito { get; set; }

    public int Idcompetenza { get; set; }

    public string? Competenza { get; set; }

    public string? Ambito { get; set; }
}
