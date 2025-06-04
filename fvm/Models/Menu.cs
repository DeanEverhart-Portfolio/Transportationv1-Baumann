using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fvm.Models
{
    public class Menu
    {
        public int MenuID { get; set; }

        public string MenuDesignator { get; set; }
    }
}

            //ViewBag.RunID = db.Runs.Select(a => new SelectListItem
            //{
            //    Value = a.RunID.ToString(),
            //    Text = a.RunDesignator + " " + a.RunTimeArriveHr + " " + a.RunTimeArriveMin
            //}
            //).ToList();