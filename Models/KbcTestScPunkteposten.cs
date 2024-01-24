using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class KbcTestScPunkteposten
{
    public int LfdNr { get; set; }

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public DateTime Buchungsdatum { get; set; }

    public int Belegart { get; set; }

    public string? Belegnr { get; set; }

    public string? Herkunftsnr { get; set; }

    public string? ScVertragsNrSlm { get; set; }

    public int GeschäftsfallBelegart { get; set; }

    public string? GeschäftsfallNr { get; set; }

    public decimal ScPunkteBetrag { get; set; }

    public decimal Betrag { get; set; }

    public string? RechAnDebNr { get; set; }

    public decimal ScPunkteRestbetrag { get; set; }

    public decimal ScPunkteBetragNaz { get; set; }

    public decimal ScPunkteBetragÜst { get; set; }

    public decimal ScPunkteBetragÜst2Nsf { get; set; }

    public decimal ScPunkteBetragPauschalen { get; set; }

    public int ScPunkteGuthabenLfdNr { get; set; }

    public string? Beschreibung { get; set; }

    public string? Beschreibung2 { get; set; }

    public string? LeistungsartRessource { get; set; }

    public string? NameRessourceBenutzer { get; set; }

    public DateTime DatumZeiterfassungRechnung { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
