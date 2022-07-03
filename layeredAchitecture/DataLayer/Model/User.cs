using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataLayer.Model
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; } 
        public string Mail { get; set; }
        public string Password { get; set; }

       
        public List<Address> Addresses { get; set; } //navigation prop
        public List<Order> Orders { get; set; }
        public List<Favorite> Favorites { get; set; }
    }
}
