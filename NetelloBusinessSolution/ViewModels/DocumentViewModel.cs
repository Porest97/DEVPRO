using NetelloBusinessSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetelloBusinessSolution.ViewModels
{
    public class DocumentViewModel
    {

        [Display(Name = "Document Name")]
        public string DocumentName { get; set; }

        [Display(Name = "Document Description")]
        public string DocumentDescription { get; set; }

        [Display(Name = "Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; } = DateTime.Now;


        [Display(Name = "Document Link")]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        [Display(Name = "Owner")]
        public int? PersonId { get; set; }
        [Display(Name = "Owner")]        
        public Person Owner { get; set; }
    }
}
