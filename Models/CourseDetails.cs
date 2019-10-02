using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class CourseDetails
    {
        [Key]
        public int courseDetailID { get; set; }
        public string courseName { get; set; }
        public string description { get; set; }
        public int hours { get; set; }
        public DateTime startDate { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}