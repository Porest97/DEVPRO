using System.ComponentModel.DataAnnotations;

namespace PROContacts.Models
{
    public class Sport
    {
        public int Id { get; set; }
        [Display(Name ="Sport")]
        public string SportName { get; set; }
    }
}