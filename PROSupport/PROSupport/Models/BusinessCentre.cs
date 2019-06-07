﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROSupport.Models
{
    public class BusinessCentre
    {
        public int Id { get; set; }

        [Display(Name = "Date Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }
        [Display(Name = "Company")]
        public Company Company { get; set; }


        [Display(Name = "Centre Number")]
        public int? CentreNumber { get; set; }


        [Display(Name = "Centre Name")]
        public string CentreName { get; set; }

        [Display(Name = "CName")]
        public string CName { get { return string.Format("{0} {1} {2}", CentreNumber, CentreName, Address); } }


        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "ZIP Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string County { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2} {3}", StreetAddress, ZipCode, County, Country); } }

        [Display(Name = "Centre NO, Name and Address")]
        public string WiFiSurvString { get { return string.Format("{0} {1} {2} {3}", CentreNumber, CentreName, Address, Country); } }

        [Display(Name = "# of Floors")]
        public int? NumberOfFloors { get; set; }

        [Display(Name = "Centre Contact")]              
        public int? PersonId { get; set; }
        [Display(Name = "Centre Contact")]
        [ForeignKey("PersonId")]
        public Person CentreContact { get; set; }

        [Display(Name = "Centre Manager")]
        public int? PersonId1 { get; set; }
        [Display(Name = "Centre Manager")]
        [ForeignKey("PersonId1")]
        public Person CentreManager { get; set; }


        [Display(Name = "Centre Notes")]
        public string CentreNotes { get; set; }


        [Display(Name = "Centre Documents")]
        public ICollection<Document> BCDocuments { get; set; }




    }
}
