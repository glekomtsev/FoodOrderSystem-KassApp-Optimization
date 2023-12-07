using System;
using System.Collections.Generic;

namespace CafeAppSql;

public partial class Order
{
    public int OrderId { get; set; }

    public int WaiterId { get; set; }

    public DateTime OrderTime { get; set; }

    public virtual Waiter Waiter { get; set; } = null!;
}
