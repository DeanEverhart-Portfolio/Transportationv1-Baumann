using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }

        public string EquipmentDesignator { get; set; }

        public virtual ICollection<EquipmentHistory> EquipmentHistory { get; set; }

        public virtual ICollection<EquipmentAssignment> EquipmentAssignments { get; set; }

        public virtual ICollection<Clock> Clocks { get; set; }

        // ________________________________________

        public string EquipmentDown { get; set; }

        public string EquipmentDOT { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DOT Date")]
        public DateTime? EquipmentDOTDate { get; set; }

        public String EquipmentDOTDateText { get; set; }

        public int? EquipmentRadio { get; set; }

        public bool? EquipmentRadioReported { get; set; }

        [Display(Name = "Radio")]
        public string EquipmentRadioDisplay //{ get; set; }
        {
            get
            {
                return EquipmentRadio + " " + EquipmentRadioReported;
            }
        }

        public string EquipmentRadioNote { get; set; }

        [Display(Name = "Status")]
        public string EquipmentStatusDisplay //{ get; set; }
        {
            get
            {
                return  EquipmentDOT + " " + EquipmentDOTDateText + " " + EquipmentDown;
            }
        }

        [Display(Name = "DOT")]
        public string EquipmentDOTDisplay //{ get; set; }
        {
            get
            {
                return EquipmentDOT + "" + EquipmentNote + "" + EquipmentDOTDateText;
            }
        }

        [Display(Name = "DOT")]
        public string EquipmentDOTDisplay2 //{ get; set; }
        {
            get
            {
                return EquipmentDOT + "" + EquipmentDOTDateText;
            }
        }

        public string EquipmentReplacement { get; set; }

        public string EquipmentNote { get; set; }

        public string EquipmentText { get; set; }

        [Display(Name = "DOT")]
        public string EquipmentDownDisplay //{ get; set; }
        {
            get
            {
                return EquipmentDown + EquipmentNote;
            }
        }

        public string EquipmentLocation { get; set; }

        public string EquipmentLocationBook { get; set; }

        public int? EquipmentVideo { get; set; }

        public string EquipmentVideo2 { get; set; }

        [Display(Name = "Vehicle")]
        public string EquipmentDesignatorVideo2Display //{ get; set; }
        {
            get
            {
                return EquipmentDesignator + " " + EquipmentVideo2;
            }
        }

        public string EquipmentType { get; set; }

        public int? EquipmentPassengersAdult { get; set; }

        public int? EquipmentPassengersChild { get; set; }

        public int? EquipmentBuiltIns { get; set; }

        public int? EquipmentWheelChair { get; set; }

        public bool? EquipmentSelect { get; set; }
        public bool? EquipmentInactive { get; set; }
    }
}