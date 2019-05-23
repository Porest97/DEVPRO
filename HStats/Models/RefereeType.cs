using System.ComponentModel.DataAnnotations;

namespace HStats.Models
{
    public class RefereeType
    {
        public int Id { get; set; }

        [Display(Name = "Domartyp")]
        public string RefereeTypeName { get; set; }
    }
}