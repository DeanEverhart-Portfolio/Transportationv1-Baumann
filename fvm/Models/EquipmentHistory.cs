using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class EquipmentHistory
    {
        public int EquipmentHistoryID { get; set; }

        public int EquipmentID { get; set; }

        public int ContactID { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Route Route { get; set; }

        // ________________________________________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime? EquipmentHistoryDate { get; set; }

        public string EquipmentHistoryCategory { get; set; }

        public string EquipmentHistoryCategorySub { get; set; }

        public string EquipmentHistoryNote { get; set; }

        public bool? EquipmentHistorySelect { get; set; }
        public bool? EquipmentHistoryInactive { get; set; }
    }
}