using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Areas.Home.Models
{
    public class Coorespondence
    {
        public int CoorespondenceID { get; set; }
        public string CoorespondenceFrom { get; set; }
        public string CoorespondenceCategory { get; set; }
        public string CoorespondenceCategorySub { get; set; }

        [Display(Name = "Phone 1")]
        public string CoorespondenceCategoryDisplay //{ get; set; }
        {
            get
            {
                return CoorespondenceCategory + " " + CoorespondenceCategorySub;
            }
        }

        public string CoorespondenceText { get; set; }
        public string CoorespondenceTextFull { get; set; }
        public string CoorespondenceImage { get; set; }
        public string CoorespondenceDescription { get; set; }
        public string CoorespondenceTag { get; set; }
        
        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime? CoorespondenceDate { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public DateTime? CoorespondenceTime { get; set; }

        public int CoorespondenceTimeHr { get; set; }
        public int CoorespondenceTimeMin { get; set; }

        [Display(Name = "Phone 1")]
        public string CoorespondenceDateTimeDisplay //{ get; set; }
        {
            get
            {
                return CoorespondenceDate + " " + CoorespondenceTime;
            }
        }

        public string CoorespondenceAMPM { get; set; }

        public string CoorespondenceDayOfWeek { get; set; }

        public bool? CoorespondenceSelect { get; set; }
        public bool? CoorespondenceInactive { get; set; }
    }
}