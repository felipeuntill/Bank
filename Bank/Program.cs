using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create a bank");
            Bank bank = new Bank("First Ban & Trust"); // create a bank

            Console.WriteLine("\nCreating some accounts:");
            bank.AddAcount(AccountType.Checking, "First Owner");
            bank.AddAcount(AccountType.CorporateInvestment, "Sally Second");
            bank.AddAcount(AccountType.IndividualInvestment, "Ted Third");

            Console.WriteLine("\nDeposit $25.35 into 'First Owner's Checking");
            bank.FindAccount(AccountType.Checking, "First Owner").Deposit(25.35);

            Console.WriteLine("\nTry to withdraw $100.50 From Ted's individual Investment - should fail");
            try {
                bank.FindAccount(AccountType.IndividualInvestment, "Ted Third").Withdraw(100.50);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nDeposit $1500 Ted's individual Investment");
            bank.FindAccount(AccountType.IndividualInvestment, "Ted Third").Deposit(1500.0);

            Console.WriteLine("\nTry to withdraw $1001.00 From Ted's individual Investment - should fail");
            try
            {
                bank.FindAccount(AccountType.IndividualInvestment, "Ted Third").Withdraw(1001.00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n\n=========================================================================================\n" + bank.ListAccounts());
        }
    }
}
