using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormRegistrationSystem.Models
{
    public class ContactModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}