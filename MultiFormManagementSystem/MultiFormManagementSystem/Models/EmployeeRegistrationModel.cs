using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormManagementSystem.Models
{
    public class EmployeeRegistrationModel
    {
        public string employeeid {  get; set; }
        public string employeename { get; set; }
        public string employeeemail {  get; set; }
        public long employeemobileno {  get; set; }
        public string employeedepartment {  get; set; }
        public decimal employeesalary { get; set; }
        public DateTime employeejoining {  get; set; }
        public string employeedesignation {  get; set; }
        public string employeegender {  get; set; }
        public string employeeaddress { get; set; }


    }
}