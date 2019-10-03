using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Doctor
    {
        [Key]
        public int doctorID { get; set; }
        public string doctorFirstName { get; set; }
        public string doctorLastName { get; set; }
        public string doctorPhone { get; set; }
        public string doctorEmail { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}