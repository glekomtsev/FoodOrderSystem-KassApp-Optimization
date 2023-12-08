using System;
using System.Collections.Generic;

namespace CafeAppSql;

public partial class OrderItem
{
    public int OrderId { get; set; }

    public int DishId { get; set; }

    public int Quantity { get; set; }

    public int OrderitemsId { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
