using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Verkaufslieferzeilen
{
    public string BelegNummer { get; set; } = null!;

    public int ZeilenNummer { get; set; }

    public string? Hauptaktivitaetscode { get; set; }

    public string? Unteraktivitaetscode { get; set; }

    public DateTime Lieferdatum { get; set; }

    public int Art { get; set; }

    public string? ArtikelNummer { get; set; }

    public string? AuftragsNummer { get; set; }

    public decimal Menge { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
