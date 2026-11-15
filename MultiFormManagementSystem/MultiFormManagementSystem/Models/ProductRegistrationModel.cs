using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormManagementSystem.Models
{
    public class ProductRegistrationModel
    {
        public string productid { get; set; }

        public string productname { get; set; }

        public string productcategory { get; set; }

        public decimal productprice { get; set; }

        public int productquantity { get; set; }

        public string productdescription { get; set; }

        public string brandname { get; set; }

        public DateTime? manufacturingdate { get; set; }

        public DateTime? expirydate { get; set; }

        public string productstatus { get; set; }
    }
}