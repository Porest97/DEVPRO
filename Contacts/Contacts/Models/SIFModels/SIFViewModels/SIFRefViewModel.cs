using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models.SIFModels.SIFViewModels
{
    public class SIFRefViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string RefNumber { get; set; }

        public string SSN { get; set; }

        public string RefType { get; set; }


        public string RefCategory { get; set; }

        public string RefCategoryType { get; set; }


        public string RefDistrict { get; set; }

        public string RefClub { get; set; }


        public string StreetAddress { get; set; }


        public string ZipCode { get; set; }

        public string City { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }


        public string Email { get; set; }

        public string SeasonRegistred { get; set; }


        public string Status { get; set; }

        [Display(Name = "Telefonnummer")]
        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        [Display(Name = "Namn")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }


        public List<SIFRef> SIFRefs { get; set; }

        public List<SIFArena> SIFArenas { get; set; }

        public List<SIFClub> SIFClubs { get; set; }

    }
}
