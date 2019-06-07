using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROContacts.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Display(Name = "Team")]
        public string TeamName { get; set; }

    }
}
