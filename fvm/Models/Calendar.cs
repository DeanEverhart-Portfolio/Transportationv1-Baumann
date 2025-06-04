using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Calendar
    {
        public int CalendarID { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime? CalendarDate { get; set; }

        [Display(Name = "Day of Week")]
        public string CalendarDateDayOfWeek { get; set; }

        [Display(Name = "Holiday")]
        public string CalendarDateHoliday { get; set; }

        [Display(Name = "Display")]
        public bool? CalendarDisplay { get; set; }

        [Display(Name = "Item")]
        public string CalendarDateItem { get; set; }

        [Display(Name = "Event")]
        public string CalendarDateSchoolEvent { get; set; }

        [Display(Name = "Category")]
        public string CalendarDateCategory { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public DateTime? CalendarDateTimeDismissal { get; set; }

        [Display(Name = "Dismissal Time")]
        public string CalendarDateTimeDismissalText { get; set; }

        [Display(Name = "Event")]
        public string CalendarDateCategoryTimeDisplay //{ get; set; }
        {
            get
            {
                return CalendarDateCategory + " " + CalendarDateTimeDismissalText;
            }
        }

        [Display(Name = "Additional Information")]
        public string CalendarDateAdditionalInformation { get; set; }

        [Display(Name = "Publish")]
        public bool? CalendarDatePublish { get; set; }

        public bool? CalendarSelect { get; set; }

        public bool? CalendarInactive { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime? CalendarDateStart { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime? CalendarDateEnd1 { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Including Weekend")]
        public DateTime? CalendarDateEnd2 { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Return Date")]
        public DateTime? CalendarDateReturn { get; set; }

        [Display(Name = "Day of Week")]
        public string CalendarDateDayOfWeekReturn { get; set; }

        [Display(Name = "Return")]
        public string CalendarDateReturnDisplay //{ get; set; }
        {
            get
            {
                return CalendarDateDayOfWeekReturn + " " + CalendarDateReturn;
            }
        }

        //______________________________________________________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Old Start Date")]
        public DateTime? CalendarDateFirst { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Old End Date")]
        public DateTime? CalendarDateLast { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date 2")]
        public DateTime? CalendarDateLast2 { get; set; }

        //[Display(Name = "FullNameDisplay")]
        //public string ContactFullNameDisplay //{ get; set; }
        //{
        //    get
        //    {
        //        return ContactNameLast + " " + ContactNameFirst;
        //    }
        //}
    }
}