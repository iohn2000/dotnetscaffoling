using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class KbcTestVertragSlm
{
    public string Nr { get; set; } = null!;

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public DateTime Ablaufdatum { get; set; }

    public string? Beschreibung { get; set; }

    public DateTime Startdatum { get; set; }

    public int Status { get; set; }

    public string? Herkunftsnr { get; set; }

    public int Herkunftsart { get; set; }

    public byte ServiceCard { get; set; }

    public int ScSubart { get; set; }

    public string? PreisgruppencodeTechnologie { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
