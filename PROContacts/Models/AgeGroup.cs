using System.ComponentModel.DataAnnotations;

namespace PROContacts.Models
{
    public class AgeGroup
    {
        public int Id { get; set; }

        [Display(Name ="Åldersgrup")]
        public string AgeGroupName { get; set; }
    }
}