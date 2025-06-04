using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column

namespace fvm.Areas.Office.Models
{
    public class Supply
    {
        public int SupplyID { get; set; }
        public string SupplyDesignator { get; set; }
        public string SupplyCategory { get; set; }
        public string SupplyCategorySub { get; set; }
        [Display(Name = "IDs")]
        public string SupplyCategoriesDisplay //{ get; set; }
        {
            get
            {
                return SupplyCategory + " " + SupplyCategorySub;
            }
        }

        public string SupplyItemNumber { get; set; }

        public string SupplyModelNumber { get; set; }

        public string SupplySerialNumber { get; set; }

        [Display(Name = "IDs")]
        public string SupplyIDsDisplay //{ get; set; }
        {
            get
            {
                return SupplyItemNumber + " " + SupplyModelNumber;
            }
        }

        public string SupplyVariety { get; set; }
        public string SupplyColor { get; set; }
        public string SupplySize { get; set; }
        public string SupplyDimensions { get; set; }
        public string SupplyDescription { get; set; }

        [Display(Name = "IDs")]
        public string SupplyDescriptionDisplay //{ get; set; }
        {
            get
            {
                return SupplySize + " " + SupplyColor + " " + SupplyDimensions + " " + SupplyVariety + " " + SupplyDescription;
            }
        }

        public int? SupplyCount { get; set; }
        public int? SupplyPack { get; set; }
        public int? SupplyOrderQuantity { get; set; }
        public string SupplyUnitPriceString { get; set; }
        public string SupplyTag { get; set; }
        public string SupplyNote { get; set; }
        public string SupplyURLAccess { get; set; }
    }
}