using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataLayer.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Body { get; set; }
        public User User { get; set; } //navıgatın prop
       
        public int UserId { get; set; } //FK bagladim

    }
}
