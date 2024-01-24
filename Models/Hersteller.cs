using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Hersteller
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Artikelpräfix { get; set; }

    public bool Gesperrt { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }
}
