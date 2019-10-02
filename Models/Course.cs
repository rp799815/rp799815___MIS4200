using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Course
    {
        [Key]
        public int courseID { get; set; }
        public string courseName { get; set; }
        public DateTime startDate { get; set; }
        public ICollection<CourseDetails> CourseDetail { get; set; }
        public int instructorID { get; set; }
        public virtual Instructors Instructor { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}