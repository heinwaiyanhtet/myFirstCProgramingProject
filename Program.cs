using BankyStuffLibray;
using System;
using System.Collections.Generic;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
          // Console.WriteLine("car".Pluralize());
          // Console.WriteLine("pant".Pluralize());
          // Console.WriteLine("octopus".Pluralize());
          // Console.WriteLine(3501.ToWords());


        var account = new BankAccount("Kendra", 1000);
          Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

          account.MakeWithdrawl(120,DateTime.Now,"Hammock");

          //Test that the initial balance must be positive

          account.MakeWithdrawl(50,DateTime.Now,"Xbox Game");
          Console.WriteLine(account.GetAccountHistory());

          //Test for a negative balance
          // try
          // {
          //   account.MakeWithdrawl(75000,DateTime.Now,"Attempt to overdraw");
          // }
          // catch(InvalidOperationException e)
          // {
          //   Console.WriteLine("Exception caught trying to overview");
          //   Console.WriteLine(e.ToString());
          // }

          // //Test that the initial value must be positive
          // try
          // {
          //   var invalidAccount = new BankAccount("invalid",-55);
          // }
          // catch(ArgumentException e)
          // {
          //   Console.WriteLine("Exception caught creating with negative balance");
          //   Console.WriteLine(e.ToString());
          // }
        }
    }
}