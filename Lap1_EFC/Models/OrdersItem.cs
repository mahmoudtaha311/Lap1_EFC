using System;
using System.Collections.Generic;

namespace Lap1_EFC.Models;

public partial class OrdersItem
{
    public int Orderid { get; set; }

    public int Itemid { get; set; }

    public virtual Item Item { get; set; } = null!;
}
