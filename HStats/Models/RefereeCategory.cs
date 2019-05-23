using System.ComponentModel.DataAnnotations;

namespace HStats.Models
{
    public class RefereeCategory
    {
        public int Id { get; set; }

        [Display(Name = "Domarkategori")]
        public string RefereeCategoryName { get; set; }
    }
}