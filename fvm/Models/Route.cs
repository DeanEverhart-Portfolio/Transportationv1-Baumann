using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Route
    {
        public int RouteID { get; set; }

        [Display(Name = "Route")]
        public string RouteDesignator { get; set; }

        public int? ContactID { get; set; }

        public int? RunID { get; set; }

        public virtual ICollection<RouteAssignment> RouteAssignments { get; set; }

        public virtual ICollection<Clock> Clocks { get; set; }

        // ________________________________________

        [Display(Name = "Route")]
        public string RouteDesignator2 { get; set; }

        public string RouteDistrict { get; set; }

        public string RouteHardware { get; set; }

        public string RouteSupervision { get; set; }

        public string RouteMonitors { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Report AM")]
        public DateTime? RouteTimeReportAM { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Report PM")]
        public DateTime? RouteTimeReportPM { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arrive AM")]
        public DateTime? RouteTimeArriveAM { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arrive PM")]
        public DateTime? RouteTimeArrivePM { get; set; }

        public bool? RouteTimeShiftAM { get; set; }

        public bool? RouteTimeShiftPM { get; set; }

        public bool? RouteSelect { get; set; }
        public bool? RouteInactive { get; set; }
    }
}