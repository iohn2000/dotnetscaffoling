using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class OrderItem
{
    public string Id { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public decimal OrderedQuantity { get; set; }

    public decimal DeliveredQuantity { get; set; }

    public string? Key { get; set; }

    public string? Number { get; set; }

    public string? Description { get; set; }
}
