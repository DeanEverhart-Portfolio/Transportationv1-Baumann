using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fvm.Areas.Education.Models
{
    public class CDL
    {
        public int CDLID { get; set; }
        public string CDLCategory { get; set; }
        public string CDLCategorySub { get; set; }
        public string CDLTag { get; set; }
        public string CDLText1 { get; set; }
        public string CDLText2 { get; set; }
        public int? CDLChapter { get; set; }
        public int? CDLPage { get; set; }

        public bool? CDLSelect { get; set; }
        public bool? CDLInactive { get; set; }
    }
}