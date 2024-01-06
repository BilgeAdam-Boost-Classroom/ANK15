using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class ProductGetNullCategoryRightJoin
    {
        public string? ProductName { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
