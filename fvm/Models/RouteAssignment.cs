using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class RouteAssignment
    {
        public int RouteAssignmentID { get; set; }

        public int? RouteID { get; set; }

        public int? RunID { get; set; }

        public int? ContactID { get; set; }
        
        public int? EquipmentID { get; set; }

        //public int? RunID { get; set; }

        public virtual Route Route { get; set; }

        public virtual Run Run { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Equipment Equipment { get; set; }

        //public virtual Run Run { get; set; }

        // ________________________________________
        [Display(Name = "Replacement")]
        public string RouteAssignmentReplacement { get; set; }

        [Display(Name = "Replacement Type")]
        public string RouteAssignmentReplacementType { get; set; }
    }
}