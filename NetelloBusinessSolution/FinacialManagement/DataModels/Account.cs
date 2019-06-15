using Microsoft.AspNetCore.Identity;
using NetelloBusinessSolution.FinacialManagement.DataModels;
using NetelloBusinessSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetelloBusinessSolution.FinacialManagement
{
    public class Account
    {
        public int Id { get; set; }

        public int AccountNumber { get; set;}

        public string AccountName { get; set; }

        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person AccountHolder { get; set; }

        public int AccountTypeId { get; set; }
        [ForeignKey("AccountTypeId")]
        public AccountType AccountType { get; set; }

        public string TransactionText { get; set; }

        public decimal Debit { get; set; }

        public decimal Credit { get; set; }

        public decimal Balance { get; set; }


    }
}
