using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class DataLoadSource
{
    public int DataSourceId { get; set; }

    public string? DataSourceName { get; set; }

    public virtual ICollection<DataLoadHistory> DataLoadHistories { get; set; } = new List<DataLoadHistory>();

    public virtual ICollection<Debitor> Debitors { get; set; } = new List<Debitor>();

    public virtual ICollection<InteressentStatus> InteressentStatuses { get; set; } = new List<InteressentStatus>();

    public virtual ICollection<Interessent> Interessents { get; set; } = new List<Interessent>();

    public virtual ICollection<KbcTestGeschäftsfall> KbcTestGeschäftsfalls { get; set; } = new List<KbcTestGeschäftsfall>();

    public virtual ICollection<KbcTestKundenbenachrichtEinrichtung> KbcTestKundenbenachrichtEinrichtungs { get; set; } = new List<KbcTestKundenbenachrichtEinrichtung>();

    public virtual ICollection<KbcTestScPunkteposten> KbcTestScPunktepostens { get; set; } = new List<KbcTestScPunkteposten>();

    public virtual ICollection<KbcTestVertragSlm> KbcTestVertragSlms { get; set; } = new List<KbcTestVertragSlm>();

    public virtual ICollection<KbcTestZeiterfassungsposten> KbcTestZeiterfassungspostens { get; set; } = new List<KbcTestZeiterfassungsposten>();

    public virtual ICollection<Kontaktperson> Kontaktpeople { get; set; } = new List<Kontaktperson>();

    public virtual ICollection<NdeasyDokumentArchiv> NdeasyDokumentArchivs { get; set; } = new List<NdeasyDokumentArchiv>();

    public virtual ICollection<Resource> Resources { get; set; } = new List<Resource>();

    public virtual ICollection<Verkaufsgutschriftszeilen> Verkaufsgutschriftszeilens { get; set; } = new List<Verkaufsgutschriftszeilen>();

    public virtual ICollection<Verkaufslieferzeilen> Verkaufslieferzeilens { get; set; } = new List<Verkaufslieferzeilen>();

    public virtual ICollection<Verkaufsrechnungszeilen> Verkaufsrechnungszeilens { get; set; } = new List<Verkaufsrechnungszeilen>();

    public virtual ICollection<VerkäuferEinkäufer> VerkäuferEinkäufers { get; set; } = new List<VerkäuferEinkäufer>();

    public virtual ICollection<Versanddaten> Versanddatens { get; set; } = new List<Versanddaten>();
}
