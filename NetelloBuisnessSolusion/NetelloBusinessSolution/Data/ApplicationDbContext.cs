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
    }
}
