using System;
using System.Collections.Generic;

namespace CafeAppSql;

public partial class OrderSummary
{
    public int? НомерЗаказа { get; set; }

    public string? Официант { get; set; }

    public decimal? СуммаЗаказа { get; set; }

    public DateTime? ДатаЗаказа { get; set; }

    public long? КоличествоБлюд { get; set; }
}
