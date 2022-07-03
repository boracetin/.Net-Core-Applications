using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataLayer.Model
{
    public class ProductFavorite
    {
       
        public int FavoriteId { get; set; }
        public Favorite Favorite { get; set; }



        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
