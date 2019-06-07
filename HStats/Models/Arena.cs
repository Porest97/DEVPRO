using System.ComponentModel.DataAnnotations;

namespace HStats.Models
{
    public class Arena
    {
        public int Id { get; set; }

        [Display(Name = "Arena")]
        public string ArenaString { get { return string.Format("{0} {1} {2}", ArenaName, "-", ArenaCounty); } }

        [Display(Name = "Plats")]
        public string LocationString { get { return string.Format("{0} {1}", ArenaName, ArenaAddress); } }

        [Display(Name = "Arena")]
        public string ArenaName { get; set; }

        [Display(Name = "Gatuadress")]
        public string ArenaStreetAddress { get; set; }

        [Display(Name = "Post Nr")]
        [DataType(DataType.PostalCode)]
        public string ArenaZipCode { get; set; }

        [Display(Name = "Post Ort")]
        public string ArenaCounty { get; set; }

        [Display(Name = "Land")]
        public string ArenaCountry { get; set; }

        [Display(Name = "Adress")]
        public string ArenaAddress { get { return string.Format("{0} {1} {2} {3}", ArenaStreetAddress, ArenaZipCode, ArenaCounty, ArenaCountry); } }

    }
}