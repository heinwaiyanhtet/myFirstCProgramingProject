using System.Transactions;
using System;
using System.Collections.Generic;
using System.Text;
using Humanizer;

namespace BankyStuffLibray{
    class Transition
    {
        public decimal Amount{get;}

        public string AmountForHumans{
            get{
                return   ((int)Amount).ToWords();
            }
        }
        public DateTime Date { get;}
        public string Notes { get; }
        public Transition(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date  = date;
            this.Notes = note;
        }
    }
}
