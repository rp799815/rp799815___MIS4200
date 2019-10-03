using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Appointment
    {
        [Key]
        public int apptointmentID { get; set; }
        public string reasonForVisit { get; set; }
        public DateTime appointmentDate { get; set; }

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}