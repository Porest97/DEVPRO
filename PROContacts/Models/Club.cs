using System.ComponentModel.DataAnnotations;

namespace PROContacts.Models
{
    public class Club
    {
        public int Id {get; set; }

        [Display(Name ="Klubb")]
        public string ClubName { get; set; }
    }
}