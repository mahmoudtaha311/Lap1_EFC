using System;
using System.Collections.Generic;

namespace Lap1_EFC.Models;

public partial class Item
{
    public int Id { get; set; }

    public string? ItemName { get; set; }

    public int? Userid { get; set; }

    public virtual ICollection<OrdersItem> OrdersItems { get; set; } = new List<OrdersItem>();
}
