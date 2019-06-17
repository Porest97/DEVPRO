using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contacts.Models
{
    public class Club
    {
        public int Id { get; set; }

        public string ClubName { get; set; }

        [Display(Name = "Distrikt")]
        public int? DistrictId { get; set; }
        [Display(Name = "Distrikt")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

    }
}