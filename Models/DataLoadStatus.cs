using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class DataLoadStatus
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<DataLoadHistory> DataLoadHistories { get; set; } = new List<DataLoadHistory>();
}
