using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class ProductGetNullCategoryLeftJoin
    {
        public string ProductName { get; set; } = null!;
        public string? CategoryName { get; set; }
    }
}
