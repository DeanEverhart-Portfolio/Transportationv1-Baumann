using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fvm.Models
{
    public class EquipmentAssignment
    {
        public int EquipmentAssignmentID { get; set; }

        public int EquipmentID { get; set; }

        public int ContactID { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Contact Contact { get; set; }

        // ________________________________________
    }
}