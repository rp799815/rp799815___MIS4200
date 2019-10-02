using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rp799815_MIS4200.Models
{
    public partial class Instructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int instructorID { get; set; }
        public string instructorFirstName { get; set; }
        public string instructorIastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ICollection<Courses> Course { get; set; }
    }
}