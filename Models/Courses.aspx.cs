using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rp799815_MIS4200.Models
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int courseID { get; set; }
        public string courseName { get; set; }
        public DateTime startDate { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
        public int studentID { get; set; }
        public virtual Students Student { get; set; }

    }
}