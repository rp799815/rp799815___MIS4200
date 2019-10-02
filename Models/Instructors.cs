using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Instructors
    {
        [Key]
        public int instructorID { get; set; }
        public string instructorFirstName { get; set; }
        public string instructorIastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}