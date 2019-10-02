using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rp799815_MIS4200.Models;
using System.Data.Entity;

namespace rp799815_MIS4200.DAL
{
    public partial class MIS4200Context : DbContext // inherits from DbContext
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructors> Instructor { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<CourseDetails> CourseDetail { get; set; }

    }
}