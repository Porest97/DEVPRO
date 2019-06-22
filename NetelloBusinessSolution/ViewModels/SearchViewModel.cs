using NetelloBusinessSolution.Models;
using NetelloBusinessSolution.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetelloBusinessSolution.ViewModels
{
    public class SearchViewModel
    {
        public List<Person> People { get; set; }
        public List<BusinessCentre> BusinessCentres { get; set; }
        public List<Company> Companies { get; set; }
        public List<Document> Documents { get; set; }
        public List<DworkinWiFiSurveyResult> DworkinWiFiSurveyResults { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<Meeting> Meetings { get; set; }
        public List<PROWorkReport> PROWorkReports { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; }

        public List<SupportCase> SupportCases { get; set; }

        

        public List<SupportTicket> SupportTickets { get; set; }

        public List<WorkReport> WorkReports { get; set; }


    }
}
