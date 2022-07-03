using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataLayer.Model
{
    public class Favorite
    {

        public int Id { get; set; }

        public int UserId { get; set; } //FK
        public User User { get; set; }

        public ICollection<ProductFavorite> Products { get; set; } //ICollection

    }
}
