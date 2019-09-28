using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models.Schedule
{
    public class Schedule
    {
        public int Id { get; set; }

        [Display(Name = "Vecka")]
        public int? WeekNumber { get; set; }

        [Display(Name = "Namn")]
        public int? PersonId { get; set; }
        [Display(Name = "Namn")]
        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        [Display(Name = "Måndag")]
        public string Monday { get; set; }
        public decimal HoursMonday { get; set; }

        [Display(Name = "Tisdag")]
        public string Tuesday { get; set; }
        public decimal HoursTuesday { get; set; }

        [Display(Name = "Onsdag")]
        public string Wednesday { get; set; }
        public decimal HoursWednesday { get; set; }

        [Display(Name = "Torsdag")]
        public string Thursday { get; set; }
        public decimal HoursThursday { get; set; }

        [Display(Name = "Fredag")]
        public string Friday { get; set; }
        public decimal HoursFriday { get; set; }

        [Display(Name = "Lördag")]
        public string Saturday { get; set; }
        public decimal HoursSaturday { get; set; }

        [Display(Name = "Söndag")]
        public string Sunday { get; set; }
        public decimal HoursSunday { get; set; }

        [Display(Name = "Antal Timmar")]
        public decimal TotalHours { get; set; }



    }
}
