using System;
using System.Collections.Generic;

namespace EcommerceCheckoutAPI.Models;

public class WatchCatalogue
{
    public int WatchId { get; set; }

    public string WatchName { get; set; } = null!;

    public int UnitPrice { get; set; }

    public int? Discount { get; set; }

    public int? Quantity { get; set; }
}
