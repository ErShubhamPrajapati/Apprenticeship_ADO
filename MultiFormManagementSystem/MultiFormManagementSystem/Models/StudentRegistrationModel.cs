using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormManagementSystem.Models
{
    public class StudentRegistrationModel
    {
        public string studentid { get; set; }
        public string studentname { get; set; }
        public string studentemail { get; set; }
        public long studentmobileno { get; set; }
        public DateTime? studentdob { get; set; }
        public string studentgender { get; set; }
        public string studentaddress { get; set; }
        public string fathername { get; set; }
        public string studentqualification { get; set; }
        public DateTime? studentregistration { get; set; }
    }
}