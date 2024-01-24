using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Debitor
{
    public string Nr { get; set; } = null!;

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? Name { get; set; }

    public string? Name2 { get; set; }

    public string? Address { get; set; }

    public string? Ort { get; set; }

    public string? Postalcode { get; set; }

    public bool Gesperrt { get; set; }

    public string UstIdNr { get; set; } = null!;

    public string VerkaeuferCode { get; set; } = null!;

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
