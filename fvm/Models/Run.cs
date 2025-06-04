using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Run
    {
        public int RunID { get; set; }

        [Display(Name = "Run")]
        public string RunDesignator { get; set; }

        [Display(Name = "Route")]
        public int? RouteID { get; set; }

        [Display(Name = "Contact")]
        public int? ContactID { get; set; }

// ______________________________________________________

        public virtual Route Route { get; set; }

        public virtual Contact Contact { get; set; }

        // ____________________________________________

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public DateTime? RunTime { get; set; }

        [Display(Name = "AM / PM")]
        public string RunAMPM { get; set; }

        [Display(Name = "Tier")]
        public int? RunSequence { get; set; }

        [Display(Name = "Run")]
        public string RunAMPMSequenceDisplay //{ get; set; }
        {
            get
            {
                return RunAMPM + " " + RunSequence;
            }
        }

        [Display(Name = "Day of Week")]
        public string RunDayOfWeek { get; set; }

        public string RunDistrict { get; set; }

        public string RunHardware { get; set; }

        public string RunSupervision { get; set; }

        public string RunMonitors { get; set; }

        public bool? RunSelect { get; set; }
        public bool? RunInactive { get; set; }
    }
}