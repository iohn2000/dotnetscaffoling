using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class VerkäuferEinkäufer
{
    public string Code { get; set; } = null!;

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? Name { get; set; }

    public string? AdUser { get; set; }

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string Vertriebsbereich { get; set; } = null!;

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
