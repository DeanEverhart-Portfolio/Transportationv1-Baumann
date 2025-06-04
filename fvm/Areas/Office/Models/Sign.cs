using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fvm.Areas.Office.Models
{
    public class Sign
    {
        public int SignID { get; set; }

        public string SignDesignator { get; set; }

        public string SignText { get; set; }

        public string SignCategory { get; set; }

        public string SignCategorySub { get; set; }

        public string SignURLAccess { get; set; }
    }
}