using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO_NET.Models
{
    public class StudentModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string quali { get; set; }
        public string gender { get; set; }
        public long number { get; set; }
        public DateTime dob { get; set; }
    }
}