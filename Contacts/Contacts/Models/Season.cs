using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class Season
    {
        public int Id { get; set; }


        [Display(Name ="Säsong")]
        public string SeasonName { get; set; }

    }
}
