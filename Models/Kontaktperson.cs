using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Kontaktperson
{
    public string Nr { get; set; } = null!;

    public string InteressentenNr { get; set; } = null!;

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? EindeutigeNummer { get; set; }

    public string? FullName { get; set; }

    public string? Suchbegriff { get; set; }

    public int Verantwortungsebene { get; set; }

    public string? TelefonNrGeschäftlich { get; set; }

    public string? FaxGeschäftlich { get; set; }

    public string? MobileTelefonNr { get; set; }

    public string? Email { get; set; }

    public string? AkademischerTitelcode { get; set; }

    public int Anredekennzeichen { get; set; }

    public DateTime Geburtsdatum { get; set; }

    public string? Vorname { get; set; }

    public string? Nachname { get; set; }

    public int Priority { get; set; }

    public bool NewsletterErwünscht { get; set; }

    public string? PositionLtVisitenkarte { get; set; }

    public DateTime? GeändertAmUm { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
