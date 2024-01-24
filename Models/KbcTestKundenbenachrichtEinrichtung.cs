using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class KbcTestKundenbenachrichtEinrichtung
{
    public int LfdNr { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? KontaktpersonenNr { get; set; }

    public string? VertragsnrSlm { get; set; }

    public string? Rollencode { get; set; }

    public string? Herkunftsnr { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
