using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models.ViewModels
{
    public class ContactsViewModel
    {
        
        [Display(Name = "Klubb")]
        public int? ClubId { get; set; }
        [Display(Name = "Klubb")]       
        public Club Club { get; set; }

        [Display(Name = "Team")]
        public int? TeamId { get; set; }
        [Display(Name = "Team")]        
        public Team Team { get; set; }

        [Display(Name = "Roll")]
        public int? RoleId { get; set; }
        [Display(Name = "Roll")]       
        public Role Role { get; set; }

        [Display(Name = "Sport")]
        public int? SportId { get; set; }
        [Display(Name = "Sport")]        
        public Sport Sport { get; set; }

        [Display(Name = "Distrikt")]
        public int? DistrictId { get; set; }
        [Display(Name = "Distrikt")]        
        public District District { get; set; }

        [Display(Name = "Säsong")]
        public int? SeasonId { get; set; }
        [Display(Name = "Säsong")]        
        public Season Season { get; set; }

        [Display(Name = "Födda")]
        public int? AgeCategoryId { get; set; }
        [Display(Name = "Födda")]        
        public AgeCategory AgeCategory { get; set; }

        [Display(Name = "Förnamn")]
        public String FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public String LastName { get; set; }


        [Display(Name = "Namn")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }


        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }


        [Display(Name = "Telefonnummer")]
        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }


        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "SSN#")]
        public string Ssn { get; set; }

        [Display(Name = "Kontakt")]
        public string ListString { get { return string.Format("{0} {1} {2} {3}", Club, FullName, PhoneNumbers, Email); } }

        public List<AgeCategory> AgeCategories { get; set; }

        public List<Club> Clubs { get; set; }

        public List<Contact> Contacts { get; set; }


        public List<District> Districts { get; set; }


        public List<Role> Roles { get; set; }


        public List<Season> Seasons { get; set; }

        public List<Sport> Sports { get; set; }

        public List<Team> Teams { get; set; }

    }
}
