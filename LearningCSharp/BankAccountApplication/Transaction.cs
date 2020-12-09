using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.BankAccountApplication
{
    public class Transaction
    {
        public decimal Amount { get; }

        public DateTime date { get; }

        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;

            this.date = date;

            this.Notes = notes;

        }
    }
}
