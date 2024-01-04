using System;
using System.Collections.Generic;

namespace ÖDEV_A_12.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
