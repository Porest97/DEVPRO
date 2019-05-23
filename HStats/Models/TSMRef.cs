using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HStats.Models
{
    public class TSMRef
    {
        public int Id { get; set; }

        //Ref props!
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        [Display(Name = "Domar #")]
        public string RefNumber { get; set; }

        [Display(Name = "Personnummer")]
        public string Ssn { get; set; }

        //REF props TSM !
        [Display(Name = "Domartyp")]
        public int? RefereeTypeId { get; set; }
        [Display(Name = "Domartyp")]
        [ForeignKey("RefereeTypeId")]
        public RefereeType RefereeType { get; set; }

        [Display(Name = "Kategori")]
        public int? RefereeCategoryId { get; set; }
        [Display(Name = "Kategori")]
        [ForeignKey("RefereeCategoryId")]
        public RefereeCategory RefereeCategory { get; set; }

        [Display(Name = "Kategorityp")]
        public int? RefereeCategoryTypeId { get; set; }
        [Display(Name = "Kategorityp")]
        [ForeignKey("RefereeCategoryTypeId")]
        public RefereeCategoryType RefereeCategoryType { get; set; }

        [Display(Name = "Distrikt")]
        public int? RefereeDistrictId { get; set; }
        [Display(Name = "Distrikt")]
        [ForeignKey("RefereeDistrictId")]
        public RefereeDistrict RefereeDistrict { get; set; }

        //REF Club and address props
        [Display(Name = "Klubb")]
        public int? ClubId { get; set; }
        [Display(Name = "Klubb")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

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

        

        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }


        [Display(Name = "Telefonnummer")]
        public string PhoneNumbers { get { return string.Format("{0} {1} ",PhoneNumber1, PhoneNumber2); } }

        [Display(Name = "E-Post")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
