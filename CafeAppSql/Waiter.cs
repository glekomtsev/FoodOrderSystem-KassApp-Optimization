using System;
using System.Collections.Generic;

namespace CafeAppSql;

public partial class Waiter
{
    public int WaiterId { get; set; }

    public string WaiterName { get; set; } = null!;

    public string WaiterLastname { get; set; } = null!;

    public string? WaiterPatronymic { get; set; }

    public bool? Post { get; set; }

    public string? Description { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
