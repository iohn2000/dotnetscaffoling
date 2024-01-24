using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Währungswechselkur
{
    public string Währungscode { get; set; } = null!;

    public DateTime Startdatum { get; set; }

    public decimal Wechselkursbetrag { get; set; }

    public decimal Zollwertkurs { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }
}
