using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HStats.Models
{
    public class Person
    {
        public int Id { get; set; }

        //Person props
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        [Display(Name = "Gatuadress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Post Nr")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "Post Ort")]
        public string County { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "Adress")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, County); } }

        [Display(Name = "Personnummer")]
        public string Ssn { get; set; }

        [Display(Name = "Telefonnummer")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-Post")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Klubb 1")]
        public int? ClubId { get; set; }
        [Display(Name = "Klubb 1")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        [Display(Name = "Klubb 2")]
        public int? ClubId1 { get; set; }
        [Display(Name = "Klubb 2")]
        [ForeignKey("ClubId1")]
        public Club Club1 { get; set; }

        //Person role related props !
        [Display(Name = "Domar Status")]
        public int? RefereeStatusId { get; set; }
        [Display(Name = "Domar Status")]
        public RefereeStatus RefereeStatus { get; set; }

        [Display(Name = "Tränar Status")]
        public int? CoachStatusId { get; set; }
        [Display(Name = "Tränar Status")]
        public CoachStatus CoachStatus { get; set; }

        [Display(Name = "Spelar Status")]
        public int? PlayerStatusId { get; set; }
        [Display(Name = "Spelar Status")]
        public PlayerStatus PlayerStatus { get; set; }

        [Display(Name = "Personal Status")]
        public int? StaffStatusId { get; set; }
        [Display(Name = "Personal Status")]
        public StaffStatus StaffStatus { get; set; }

        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer")]
        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber, PhoneNumber1); } }

    }
}
