using System;
using System.Collections.Generic;

namespace Login_Example.models
{
    public partial class User
    {
        public User()
        {
            Favorites = new HashSet<Favorite>();
        }

        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
