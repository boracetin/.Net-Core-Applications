using System.Collections.Generic;

namespace ETicaret.DataLayer.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public ICollection<ProductFavorite> Favorites { get; set; }
    }
}
