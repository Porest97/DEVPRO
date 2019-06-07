using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROSupport.Models;

namespace PROSupport.Models
{
    public class PROSupportContext : DbContext
    {
        public PROSupportContext (DbContextOptions<PROSupportContext> options)
            : base(options)
        {
        }

        public DbSet<PROSupport.Models.BusinessCentre> BusinessCentre { get; set; }

        public DbSet<PROSupport.Models.Company> Company { get; set; }

        public DbSet<PROSupport.Models.Document> Document { get; set; }

        public DbSet<PROSupport.Models.Person> Person { get; set; }

        public DbSet<PROSupport.Models.SupportTicket> SupportTicket { get; set; }

        public DbSet<PROSupport.Models.DworkinWiFiSurveyResult> DworkinWiFiSurveyResult { get; set; }
    }
}
