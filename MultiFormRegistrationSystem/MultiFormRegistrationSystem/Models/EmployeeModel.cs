using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormRegistrationSystem.Models
{
    public class EmployeeModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string department { get; set; }
        public decimal salary { get; set; }
        public string joiningdate { get; set; }
    }
}