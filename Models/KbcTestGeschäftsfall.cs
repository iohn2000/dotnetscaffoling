using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class KbcTestGeschäftsfall
{
    public string Nr { get; set; } = null!;

    public int Belegart { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? EinmelderAnsprechpartner { get; set; }

    public DateTime AngelegtAm { get; set; }

    public string? Beschreibung { get; set; }

    public string? Verantwortlicher { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
