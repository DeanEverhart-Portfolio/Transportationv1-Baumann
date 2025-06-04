using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Display(Name = "Contact")]
        public string ContactDesignator { get; set; }

        public virtual ICollection<Calendar> Calendars { get; set; }

        public virtual ICollection<Clock> Clocks { get; set; }

        public virtual ICollection<RouteAssignment> RouteAssignments { get; set; }

        public virtual ICollection<Route> Routes { get; set; }

        // ________________________________________

        public string ContactCategory { get; set; }
        public string ContactTitle { get; set; }
        public string ContactLicense { get; set; }
        public string ContactDesignator2 { get; set; }
        public string ContactNameFirst { get; set; }
        public string ContactEmployeeID { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DOH")]
        public DateTime? ContactDateHire { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DOH")]
        public DateTime? ContactDatePick { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DOH")]
        public DateTime? ContactDateSeniority { get; set; }

        public string ContactSchoolDistrict { get; set; }

        public string ContactPhoneLabel1 { get; set; }
        public string ContactPhoneAreaCode1 { get; set; }
        public string ContactPhone1 { get; set; }

        [Display(Name = "Phone 1")]
        public string ContactPhone1Display //{ get; set; }
        {
            get
            {
                return ContactPhoneAreaCode1 + "." + ContactPhone1;
            }
        }

        public string ContactPhoneLabel2 { get; set; }
        public string ContactPhoneAreaCode2 { get; set; }
        public string ContactPhone2 { get; set; }

        [Display(Name = "Phone 2")]
        public string ContactPhone2Display //{ get; set; }
        {
            get
            {
                return ContactPhoneAreaCode2 + " " + ContactPhone2;
            }
        }

        public string ContactPhoneLabel3 { get; set; }
        public string ContactPhoneAreaCode3 { get; set; }
        public string ContactPhone3 { get; set; }

        public string ContactNote { get; set; }

        [Display(Name = "Wireless Carrier")]
        public string ContactWirelessCarrier { get; set; }

        public string ContactAddressStreetNumber1 { get; set; }
        public string ContactAddressStreet1 { get; set; }
        public string ContactAddressStreetType1 { get; set; }

        public string ContactAddressStreetNumber2 { get; set; }        
        public string ContactAddressStreet2 { get; set; }
        public string ContactAddressStreetType2 { get; set; }

        public string ContactAddressCityTown { get; set; }
        public string ContactAddressZipCode { get; set; }


        public string ContactEmail { get; set; }
        public string ContactCalendar { get; set; }
        public string ContactCalendarOneSheet { get; set; }
        public string ContactCalendarWebsite { get; set; }
        public string ContactCalendarPublished { get; set; }


        [Display(Name = "Emergency")]
        public bool? ContactEmergency { get; set; }

        public string ContactWebsite { get; set; }
        public string ContactWebsiteDistrict { get; set; }

        public string ContactWebsiteCalendar { get; set; }

        public string ContactAddressDirections { get; set; }
        public string ContactAddressMap { get; set; }

        [Display(Name = "Tags")]
        public string ContactTag { get; set; }

        public bool? ContactSelect { get; set; }

        [Display(Name = "Inactive")]
        public bool? ContactInactive { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arrive AM")]
        public DateTime? ContactTimeArriveAM { get; set; }

        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arrive PM")]
        public DateTime? ContactTimeArrivePM { get; set; }

        [Display(Name = "Arrival Times")]
        public string ContactTimeArrivalDisplay //{ get; set; }
        {
            get
            {
                return ContactTimeArriveAM + " " + ContactTimeArrivePM;
            }
        }

        [Display(Name = "Name")]
        public string ContactNameDesignator1Or2Display //{ get; set; }
        {
            get
            {
                return ContactDesignator + " " + ContactDesignator2;
            }
        }

        [Display(Name = "Name")]
        public string ContactNameFullDisplay //{ get; set; }
        {
            get
            {
                return ContactNameFirst + " " + ContactDesignator;
            }
        }

        [Display(Name = "Name")]
        public string ContactNameFirstLastDisplay //{ get; set; }
        {
            get
            {
                return ContactDesignator + " " + ContactNameFirst;
            }
        }
    }
}