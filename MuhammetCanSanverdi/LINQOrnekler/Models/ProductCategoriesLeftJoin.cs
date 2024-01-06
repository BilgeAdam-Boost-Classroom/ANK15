using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class ProductCategoriesLeftJoin
    {
        public string? ProductName { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
