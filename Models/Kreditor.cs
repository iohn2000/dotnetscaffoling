using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Kreditor
{
    public string Nr { get; set; } = null!;

    public string? Name { get; set; }

    public string? Name2 { get; set; }

    public string? Adresse { get; set; }

    public string? Adresse2 { get; set; }

    public string? Ort { get; set; }

    public string? Ländercode { get; set; }

    public string? Plzcode { get; set; }

    public bool Gesperrt { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? Währungscode { get; set; }
}
