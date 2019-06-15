using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext (DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Contacts.Models.Contact> Contact { get; set; }
    }
}
