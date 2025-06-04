using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// end default
using fvm.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using fvm.Areas.Admin.Models;
using fvm.Areas.Education.Models;
using fvm.Areas.Home.Models;
using fvm.Areas.Office.Models;


namespace fvm.DAL
{
    public class fvmcontext : DbContext
   {   
        public fvmcontext() : base("fvmcontext") // The name of the connection string is passed in to the constructor.

        {

        }
        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Calendar> Calendars { get; set; }

        public DbSet<Clock> Clocks { get; set; }

        //public DbSet<Document> Documents { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentAssignment> EquipmentAssignments { get; set; }

        public DbSet<EquipmentHistory> EquipmentHistories { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<RouteAssignment> RouteAssignments { get; set; }

        public DbSet<Run> Runs { get; set; }

        public DbSet<RunAssignment> RunAssignments { get; set; }

        public DbSet<Admin1> Admin1s { get; set; }

        public DbSet<Admin2> Admin2s { get; set; }

        public DbSet<Admin3> Admin3s { get; set; }

        public DbSet<CDL> CDLs { get; set; }
        
        public DbSet<Supply> Supplies { get; set; }

        public DbSet<Guideline> Guidelines { get; set; }

        public DbSet<Sign> Signs { get; set; }

        // ________________________________________

        public DbSet<Coorespondence> Coorespondences { get; set; }

        // ________________________________________ Area: Hunter _______________________________________


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<fvm.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<fvm.Areas.Office.Models.Document> Documents { get; set; }
    }
}