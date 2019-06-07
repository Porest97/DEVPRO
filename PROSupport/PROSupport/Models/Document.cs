using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROSupport.Models
{
    public class Document
    {
        public int Id { get; set; }
        [Display(Name = "Document Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Date Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        [Display(Name = "Document Link")]
        public string Url { get; set; }
                        
        [Display(Name = "Owner")]
        public int? PersonId { get; set; }
        [Display(Name = "Owner")]
        [ForeignKey("PersonId")]
        public Person Owner { get; set; }



    }
}
