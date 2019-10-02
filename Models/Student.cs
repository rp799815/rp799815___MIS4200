using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace rp799815_MIS4200.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public string email { get; set; }
    }
}