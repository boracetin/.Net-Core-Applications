using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataLayer.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderTime { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
