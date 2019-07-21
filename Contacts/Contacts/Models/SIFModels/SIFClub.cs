using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models.SIFModels
{
    public class SIFClub
    {
        public int Id { get; set; }

        public string ClubNumber { get; set; }

        public string ClubName { get; set; }

        public string ShortName { get; set; }

        public string ClubAddress { get; set; }

        public string ClubCity { get; set; }


        public string ClubCountry { get; set; }

        public string ClubDistrict { get; set; }

        public string Organizer { get; set; }

        public string HomeArena { get; set; }


        public string ActiveIOL { get; set; }


        public string Status { get; set; }

        public string ClubNote { get; set; }
                        
    }
}
