using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Assignment


    {
        public int? AssignmentID { get; set; }

        public int? RouteID { get; set; }

        public int? RunID { get; set; }

        public int? ContactID { get; set; }
        
        public int? EquipmentID { get; set; }

        // ________________________________________

        public virtual Route Route { get; set; }

        public virtual Run Run { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Equipment Equipment { get; set; }

        // ________________________________________
    }
}