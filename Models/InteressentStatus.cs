using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class InteressentStatus
{
    public string Code { get; set; } = null!;

    public string? Beschreibung { get; set; }

    public bool EnthaltenInKampagnen { get; set; }

    public bool Gesperrt { get; set; }

    public bool NichtAnzeigen { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
