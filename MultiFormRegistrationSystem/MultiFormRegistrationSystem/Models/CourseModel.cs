using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormRegistrationSystem.Models
{
    public class CourseModel
    {
        public string coursename { get; set; }
        public string courseduration { get; set; }
        public decimal coursefees { get; set; }
        public string studentname { get; set; }
        public string admissiondate { get; set; }
    }
}