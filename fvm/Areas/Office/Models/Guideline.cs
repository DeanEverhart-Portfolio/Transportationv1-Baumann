using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fvm.Areas.Office.Models
{
    public class Guideline
    {
        public int GuidelineID { get; set; }

        public string GuidelineDescriptor { get; set; }

        public string GuidelineText { get; set; }

        public string GuidelineCategory { get; set; }

        public string GuidelineCategorySub { get; set; }
    }
}