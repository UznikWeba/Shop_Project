using System;
using System.Collections.Generic;

namespace WinFormsApp1;

public partial class Podcategory
{
    public int Id { get; set; }

    public string PodcategoriesName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
