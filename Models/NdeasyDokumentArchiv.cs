using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class NdeasyDokumentArchiv
{
    public string BelegNummer { get; set; } = null!;

    public string Dokumentenart { get; set; } = null!;

    public string MandantenId { get; set; } = null!;

    public int Version { get; set; }

    public string? RootIdArchiv { get; set; }

    public bool Webdarstellung { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
