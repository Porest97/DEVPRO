using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models.ViewModels
{
    public class AdminViewModel
    {
        public List<AgeCategory> AgeCategories { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Club> Clubs { get; set; }
        public List<District> Districts { get; set; }
        public List<Role> Roles { get; set; }
        public List<Sport> Sports { get; set; }
        public List<Team> Teams { get; set; }

    }
}
