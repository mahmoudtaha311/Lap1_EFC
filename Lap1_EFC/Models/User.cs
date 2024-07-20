using System;
using System.Collections.Generic;

namespace Lap1_EFC.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
