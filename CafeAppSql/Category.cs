using System;
using System.Collections.Generic;

namespace CafeAppSql;

public partial class Category
{
    public int CategoriesId { get; set; }

    public string CategoriesName { get; set; } = null!;

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();
}
