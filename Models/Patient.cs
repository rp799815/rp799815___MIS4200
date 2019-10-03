using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Patient
    {
        [Key]
        public int patientID { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }
        public string patientPhone { get; set; }
        public string patientEmail { get; set; }
        public ICollection<Appointment> Appointment { get; set; }

    }
}