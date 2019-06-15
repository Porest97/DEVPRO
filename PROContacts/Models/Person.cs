using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROContacts.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }
                
        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string County { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, County); } }

        public string Ssn { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

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
