using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class DataLoadHistory
{
    public int HistoryId { get; set; }

    public int DataHistoryStatus { get; set; }

    public int TrackedEntityId { get; set; }

    public int StartRecord { get; set; }

    public int BatchSizeRows { get; set; }

    public decimal NavTimeStampLast { get; set; }

    public int ProcessedRecordsTotal { get; set; }

    public DateTime Modified { get; set; }

    public DateTime BatchLoadStart { get; set; }

    public DateTime? LoadFinished { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public virtual DataLoadStatus DataHistoryStatusNavigation { get; set; } = null!;

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
