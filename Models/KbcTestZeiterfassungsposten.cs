using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class KbcTestZeiterfassungsposten
{
    public int Nummer { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? Technikercode { get; set; }

    public DateTime DasDatum { get; set; }

    public decimal NazDec { get; set; }

    public decimal ÜstdDec { get; set; }

    public decimal Üstd2NsfDec { get; set; }

    public string? GeschäftsfallNr { get; set; }

    public int GeschäftsfallBelegart { get; set; }

    public string? Beschreibung { get; set; }

    public decimal ScPunkteBetrag { get; set; }

    public string? ScVertragsNrSlm { get; set; }

    public bool Fakturiert { get; set; }

    public bool NichtFakturierbar { get; set; }

    public decimal KundenverrNazH { get; set; }

    public decimal KundenverrÜ1H { get; set; }

    public decimal KundenverrÜ2H { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
