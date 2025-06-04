using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class RunAssignment
    {
        public int RunAssignmentID { get; set; }

        public int? RouteID { get; set; }

        public int? RunID { get; set; }

        public virtual Route Route { get; set; }

        public virtual Run Run { get; set; }

        // ________________________________________
    }
}