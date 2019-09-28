using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Models.Schedule
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "Email1")]
        public string Email1 { get; set; }

        [Display(Name = "Email2")]
        public string Email2 { get; set; }

        [Display(Name = "Telfon1")]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefon2")]
        public string PhoneNumber2 { get; set; }

        [Display(Name = "Telefon3")]
        public string PhoneNumber3 { get; set; }

        [Display(Name = "Namn")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        [Display(Name = "Telefonnummer")]
        public string PhoneNumbers { get { return string.Format("{0} {1} {2} ", PhoneNumber1, PhoneNumber2, PhoneNumber3); } }
    }
}
