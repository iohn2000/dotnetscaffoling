using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Interessent
{
    public string Nr { get; set; } = null!;

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? Debitorennr { get; set; }

    public string? Verkäufercode { get; set; }

    public string? SapaccountId { get; set; }

    public string? Name { get; set; }

    public string? Name2 { get; set; }

    public string? Adresse { get; set; }

    public string? Adresse2 { get; set; }

    public string? PlzCode { get; set; }

    public string? Ort { get; set; }

    public string? Ländercode { get; set; }

    public string? Vertriebsbereich { get; set; }

    public bool KundeGesperrt { get; set; }

    public string? Kategorie { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
