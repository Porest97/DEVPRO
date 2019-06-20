using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetelloBusinessSolution.Models;

namespace NetelloBusinessSolution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NetelloBusinessSolution.Models.Person> Person { get; set; }
        public DbSet<NetelloBusinessSolution.Models.Company> Company { get; set; }
        public DbSet<NetelloBusinessSolution.Models.PersonType> PersonType { get; set; }
        public DbSet<NetelloBusinessSolution.Models.BusinessCentre> BusinessCentre { get; set; }
        public DbSet<NetelloBusinessSolution.Models.Document> Document { get; set; }
        public DbSet<NetelloBusinessSolution.Models.DworkinWiFiSurveyResult> DworkinWiFiSurveyResult { get; set; }
        public DbSet<NetelloBusinessSolution.Models.SupportTicket> SupportTicket { get; set; }
        public DbSet<NetelloBusinessSolution.Models.PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<NetelloBusinessSolution.Models.SupportCase> SupportCase { get; set; }
        public DbSet<NetelloBusinessSolution.Models.Course> Course { get; set; }
        public DbSet<NetelloBusinessSolution.Models.WorkReport> WorkReport { get; set; }
        public DbSet<NetelloBusinessSolution.Models.Meeting> Meeting { get; set; }
        public DbSet<NetelloBusinessSolution.Models.MeetingType> MeetingType { get; set; }
        public DbSet<NetelloBusinessSolution.Models.Invoice> Invoice { get; set; }
        public DbSet<NetelloBusinessSolution.Models.Article> Article { get; set; }
    }
}
