using System.ComponentModel.DataAnnotations;

namespace HStats.Models
{
    public class RefereeCategoryType
    {
        public int Id { get; set; }

        [Display(Name = "DomarKategorityp")]
        public string RefereeCategoryTypeName { get; set; }
    }
}