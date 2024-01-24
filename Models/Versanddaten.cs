using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Versanddaten
{
    public int LaufendeNr { get; set; }

    public string? LieferscheinNummer { get; set; }

    public DateTime Versanddatum { get; set; }

    public string? TrackingId { get; set; }

    public string? TrackingLink { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
