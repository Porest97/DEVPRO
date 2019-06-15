using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetelloBusinessSolution.ViewModels
{
    public class PersonTypeViewModel
    {
        [Display(Name = "Person Type")]
        public string PersonTypeName { get; set; }
    }
}
