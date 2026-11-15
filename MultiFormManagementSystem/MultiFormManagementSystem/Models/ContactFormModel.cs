using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiFormManagementSystem.Models
{
    public class ContactFormModel
    {
        public string contactid { get; set; }

        public string contactname { get; set; }

        public string contactemail { get; set; }

        public long contactmobileno { get; set; }

        public string contactsubject { get; set; }

        public string contactmessage { get; set; }

        public string contactcity { get; set; }

        public string contactstate { get; set; }

        public DateTime? contactdate { get; set; }

        public string contacttype { get; set; }
    }
}