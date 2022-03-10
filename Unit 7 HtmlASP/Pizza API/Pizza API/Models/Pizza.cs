using System;
using System.Collections.Generic;

namespace Pizza_API.Models
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
    }
}
