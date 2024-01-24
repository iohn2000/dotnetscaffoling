using System;
using System.Collections.Generic;

namespace navapi_scaffolding.Models;

public partial class Order1
{
    public string Id { get; set; } = null!;

    public string State { get; set; } = null!;

    public DateTime IssueDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? DebtorId { get; set; }

    public string? Description { get; set; }

    public string? OrderReference { get; set; }

    public decimal OpenQuantity { get; set; }

    public decimal OrderedQuantity { get; set; }

    public string? ProjectManagerKey { get; set; }

    public string? ProjectManagerFirstName { get; set; }

    public string? ProjectManagerLastName { get; set; }

    public string? ProjectManagerTitle { get; set; }

    public string? ProjectManagerEmail { get; set; }

    public string? ProjectManagerTelephoneBusiness { get; set; }

    public string? ProjectManagerTelephoneMobile { get; set; }

    public string? ProjectManagerUserId { get; set; }

    public bool? ProjectManagerLocked { get; set; }

    public string? DebtorContactPerson { get; set; }

    public string? DebtorDeliveryInfoAddressCity { get; set; }

    public string? DebtorDeliveryInfoAddressCountryCode { get; set; }

    public string? DebtorDeliveryInfoAddressPostalCode { get; set; }

    public string? DebtorDeliveryInfoAddressStreet { get; set; }

    public string? DebtorDeliveryInfoContactPerson { get; set; }

    public string? DebtorInvoiceAddressCity { get; set; }

    public string? DebtorInvoiceAddressCountryCode { get; set; }

    public string? DebtorInvoiceAddressPostalCode { get; set; }

    public string? DebtorInvoiceAddressStreet { get; set; }

    public string? DebtorName { get; set; }

    public string? DebtorPhone { get; set; }
}
