using System;
using System.Collections.Generic;
using System.Text;

namespace BankyStuffLibray{
    class BankAccount
    {
        public string Number{get;}
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransitions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int accountNumberSeed = 123456789;
        public List<Transition> allTransitions = new List<Transition>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;

            MakeDeposit(initialBalance,DateTime.Now,"Inital Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed ++;
        }
        public void MakeDeposit(decimal amount,DateTime date,string note)
        {
            if(amount <=0 )
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
            }
            var deposit = new Transition(amount,date,note);
            allTransitions.Add(deposit);
        }
        public void MakeWithdrawl(decimal amount,DateTime date,string note)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of withdraw must be positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for withdrawl");
            }
            var withdraw = new Transition(-amount,date,note);
            allTransitions.Add(withdraw);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\t\tamount\tNote");
            foreach (var item in allTransitions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()} \t{item.AmountForHumans}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}