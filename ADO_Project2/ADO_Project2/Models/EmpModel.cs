using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO_Project2.Models
{
    public class EmpModel
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string designation { get; set; }
        public int salary { get; set; }

    }
}