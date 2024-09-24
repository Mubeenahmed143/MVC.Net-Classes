using System;
using System.Collections.Generic;

namespace database1.Models;

public partial class Category
{
    public int CatId { get; set; }

    public string? CatName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
