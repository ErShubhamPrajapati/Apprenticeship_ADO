using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormRegistrationSystem.Models
{
    public class ProductModel
    {
        public string productname { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
    }
}