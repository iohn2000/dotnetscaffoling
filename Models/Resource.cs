using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Resource
{
    public string Nr { get; set; } = null!;

    public decimal NavTimestamp { get; set; }

    public int? DxpDataLoadSourceDataSourceId { get; set; }

    public DateTime LastSynced { get; set; }

    public string? Name { get; set; }

    public string? Name2 { get; set; }

    public virtual DataLoadSource? DxpDataLoadSourceDataSource { get; set; }
}
