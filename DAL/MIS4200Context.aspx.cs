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
    public partial class MIS4200Context :DbContext // inherits from DbContext
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }
        public DbSet<Courses> Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Students> Student { get; set; }
        public DbSet<Courses> Courses { get; set; }

    }
}