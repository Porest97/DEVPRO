using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROContacts.Models
{
    public class Person
    {
       
        [Display(Name = "Klubb")]
        public int? ClubId { get; set; }
        [Display(Name = "Klubb")]
        public Club Club { get; set; }

        [Display(Name = "Sport")]
        public int? SportId { get; set; }
        [Display(Name = "Sport")]
        public Sport Sport { get; set; }

        [Display(Name = "Distrikt")]
        public int? DistrictId { get; set; }
        [Display(Name = "Distrikt")]
        public District District { get; set; }

        [Display(Name = "Åldersgrupp")]
        public int? AgeGroupId { get; set; }
        [Display(Name = "Åldersgrupp")]
        public AgeGroup AgeGroup { get; set; }

        [Display(Name = "Team")]
        public int? TeamId { get; set; }
        [Display(Name = "Team")]
        public Team Team { get; set; }

        [Display(Name = "Säsong")]
        public int? SeasonId { get; set; }
        [Display(Name = "Säsong")]
        public Season Season { get; set; }


    }
}
