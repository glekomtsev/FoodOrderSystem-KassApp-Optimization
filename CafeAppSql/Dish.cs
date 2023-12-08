using System;
using System.Collections.Generic;

namespace CafeAppSql;

public partial class Dish
{
    public int DishId { get; set; }

    public string DishName { get; set; } = null!;

    public decimal DishPrice { get; set; }

    public int CategoriesId { get; set; }

    public virtual Category Categories { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
