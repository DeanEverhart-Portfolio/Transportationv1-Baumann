using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.ComponentModel.DataAnnotations;          // Date Format
using System.ComponentModel.DataAnnotations.Schema;   // Column


namespace fvm.Models
{
    public class Document
    {
        public int DocumentID {get; set;}

        public string DocumentDesignator { get; set; }

        public string DocumentDesignatorCategory { get; set; }

        [Display(Name = "Document")]
        public string DocumentDesignatorDisplay //{ get; set; }
        {
            get
            {
                return DocumentDesignator + " " + DocumentDesignatorCategory;
            }
        }

        public string DocumentDesignatorIdentifier { get; set; }

        public bool? DocumentForm { get; set; }

        public bool? DocumentTemplate { get; set; }

        public bool? DocumentMedical { get; set; }

        public bool? DocumentEmergency { get; set; }

        public string DocumentAccessRead { get; set; }

        public string DocumentAccessWrite { get; set; }
        
        public string DocumentCategory { get; set; }

        public string DocumentCategorySub { get; set; }

        public string DocumentVersion { get; set; }

        public string DocumentTag { get; set; }

        public string DocumentCrossCategory { get; set; }

        public string DocumentWrite { get; set; }
    }
}