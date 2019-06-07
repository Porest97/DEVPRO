using System.ComponentModel.DataAnnotations;

namespace PROContacts.Models
{
    public class Season
    {
        public int Id { get; set; }

        [Display(Name ="Säsong")]
        public string SeasonName { get; set; }
    }
}