using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rp799815_MIS4200.Models;
using System.Data.Entity;

namespace rp799815_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer (new MigrateDatabaseToLatestVersion<MIS4200Context,rp799815_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Patient> Patient { get; set; }

    }
}
        
        