using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Verkaufsrechnungszeilen
{
    public string BelegNummer { get; set; } = null!;

    public int ZeilenNummer { get; set; }

    public string? AuftragsNummer { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
