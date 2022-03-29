using System;
using System.Collections.Generic;

namespace Login_Example.models
{
    public partial class Favorite
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? MyText { get; set; }

        public virtual User? User { get; set; }
    }
}
