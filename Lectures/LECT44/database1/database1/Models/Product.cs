using System;
using System.Collections.Generic;

namespace database1.Models;

public partial class Product
{
    public int ProId { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public string? Picture { get; set; }

    public string? Descp { get; set; }

    public int? CatId { get; set; }

    public int? Quantity { get; set; }

    public virtual Category? Cat { get; set; }
}
