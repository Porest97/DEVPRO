using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROContacts.Models;

namespace PROContacts.Models
{
    public class PROContactsContext : DbContext
    {
        public PROContactsContext (DbContextOptions<PROContactsContext> options)
            : base(options)
        {
        }

        public DbSet<PROContacts.Models.AgeGroup> AgeGroup { get; set; }

        public DbSet<PROContacts.Models.Club> Club { get; set; }

        public DbSet<PROContacts.Models.District> District { get; set; }

        public DbSet<PROContacts.Models.Person> Person { get; set; }

        public DbSet<PROContacts.Models.Sport> Sport { get; set; }

        public DbSet<PROContacts.Models.Team> Team { get; set; }

        public DbSet<PROContacts.Models.Season> Season { get; set; }
    }
}
