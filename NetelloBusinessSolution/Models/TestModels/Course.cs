using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace NetelloBusinessSolution.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Display(Name = "Course Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public ICollection<Document> Documents { get; set; }
        
        public ICollection<Person> People { get; set; }

    }
}