using System;
using System.Collections.Generic;

namespace Lap1_EFC.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? NumOrder { get; set; }

    public int? UserId { get; set; }

    public int? Amount { get; set; }

    public virtual User? User { get; set; }
}
