using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROSupport.Models
{
    public class SupportTicket
    {
        public int Id { get; set; }

        [Display(Name = "Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStampCreated { get; set; } = DateTime.Now;

        [Display(Name = "Resolved")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime? TimeStampResolved { get; set; }

        [Display(Name = "Closed")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime? TimeStampClosed { get; set; }

        [Display(Name = "Business Centre")]
        [ForeignKey("BusinessCentreId")]
        public int? BusinessCentreId { get; set; }
        [Display(Name = "Business Centre")]
        public BusinessCentre BusinessCentre { get; set; }

        [Display(Name = "Ordered By")]
        public int? PersonId { get; set; }
        [Display(Name = "Ordered By")]
        [ForeignKey("PersonId")]
        public Person OrderedBy { get; set; }

        [Display(Name = "Assigned FE")]        
        public int? PersonId1 { get; set; }
        [Display(Name = "Assigned FE")]
        [ForeignKey("PersonId1")]
        public Person AssignedFE { get; set; }

        [Display(Name = "Fault Description")]
        public string FaultDescription { get; set; }

        [Display(Name = "Fault Report")]
        public string FaultReport { get; set; }

        [Display(Name = "Ticket Log")]
        public string TicketLog { get; set; }

        [Display(Name = "Ticket Documents")]
        public ICollection<Document> TicketDocuments { get; set; }

                   


    }
}
