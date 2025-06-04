using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Clock
    {
        public int ClockID { get; set; }

        [Display(Name = "Contact")]
        public int? ContactID { get; set; }

        [Display(Name = "Vehicle")]
        public int? EquipmentID { get; set; }

        [Display(Name = "Route")]
        public int? RouteID { get; set; }

        [Display(Name = "Run")]
        public string ClockRunDesignator { get; set; }


        public virtual Contact Contact { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Route Route { get; set; }

        // ____________________________________________

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public DateTime? ClockTime { get; set; }

        [Display(Name = "AM / PM")]
        public string ClockTimeAMPM { get; set; }

        [Display(Name = "Day of Week")]
        public string ClockDayOfWeek { get; set; }

        public int? ClockInactive { get; set; }
    }
}