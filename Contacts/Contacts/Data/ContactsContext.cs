using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;
using Contacts.Models.Schedule;

namespace Contacts.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext (DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Contacts.Models.Contact> Contact { get; set; }

        public DbSet<Contacts.Models.AgeCategory> AgeCategory { get; set; }

        public DbSet<Contacts.Models.Club> Club { get; set; }

        public DbSet<Contacts.Models.District> District { get; set; }

        public DbSet<Contacts.Models.Role> Role { get; set; }

        public DbSet<Contacts.Models.Sport> Sport { get; set; }

        public DbSet<Contacts.Models.Team> Team { get; set; }

        public DbSet<Contacts.Models.Season> Season { get; set; }

        public DbSet<Contacts.Models.ContactRaw> ContactRaw { get; set; }

        public DbSet<Contacts.Models.Schedule.Person> Person { get; set; }

        public DbSet<Contacts.Models.Schedule.Schedule> Schedule { get; set; }

    }
}
