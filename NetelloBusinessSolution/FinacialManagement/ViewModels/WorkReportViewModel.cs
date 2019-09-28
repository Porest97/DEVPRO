using NetelloBusinessSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetelloBusinessSolution.FinacialManagement.ViewModels
{
    public class WorkReportViewModel
    {
        

        public List<WorkReport> WorkReports { get; set; }

        
        public decimal TotalTimeWorked { get; internal set; }

        public decimal TotalPayment { get; internal set; }


        public int NumberOfPayedWRs { get; internal set; }


        public decimal TotalDueToPay { get; internal set; }
    }
}
