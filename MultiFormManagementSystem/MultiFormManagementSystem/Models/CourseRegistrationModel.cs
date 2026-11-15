using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormManagementSystem.Models
{
    public class CourseRegistrationModel
    {
        public string courseid { get; set; }
        public string coursename { get; set; }
        public string courseduration { get; set; }
        public decimal coursefees { get; set; }
        public string studentname { get; set; }
        public DateTime? admissiondate { get; set; }
        public string coursecategory { get; set; }
        public string instructorname { get; set; }
        public string paymentstatus { get; set; }
        public string coursemode { get; set; }

    }
}