using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CDAccount : SavingsAccount
    {
        private DateTime AccDate { get; set; } 

        // constructor inherits variables from SavingAmount class
        public CDAccount(string accName, string accNumber, double interestRate, decimal accBalance) 
            : base (accName, accNumber, interestRate, accBalance)
        {}

        // This function handles deposits
        // Trows exceptions if amount entered is negative
        // Calculates Balance after some years based on Interest rate and displays it
        public void Deposit(DateTime date)
        {
            decimal deposit = 0;
            Console.Write("Please, Enter Deposit Amount: ");

            deposit = decimal.Parse(Console.ReadLine());
            if (deposit <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            AccBalance = AccBalance + deposit;
            AccDate = date;
            Console.Write("Enter Number of Years: ");
            int years = int.Parse(Console.ReadLine());
            decimal profit = AccBalance * (decimal)Math.Pow((1 + InterestRate / 100.00), years);
            Console.WriteLine($"Date of Deposit:  {AccDate}\nYour Balance In {years} Years: {profit:C}\n");
        }
        
        // this function handles withdrawals
        // throws exceptions if amount entered is negative or there is not sufficient amount 
        public void Withdraw(DateTime date)
        {
            decimal withdrawal = 0;
            Console.Write("Please, Enter Withdrowal Amount: ");
            withdrawal = decimal.Parse(Console.ReadLine());
            if(withdrawal <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if((AccBalance - withdrawal) < 0)
            {
                throw new InvalidOperationException();
            }
            AccBalance = AccBalance - withdrawal;
            AccDate = date;
            Console.WriteLine($"Date of Withdrawal:  {AccDate}\n");
        }

        // overriding ToString() to display information for the user
        public override string ToString()
        {
            return "--------------------------------------------"+
                   $"\n  Account Name:{AccName, 25}\n" +
                   $"  Account Number:{AccNumber,23}\n" +
                   $"  Interest Rate:{InterestRate,23}%\n" +
                   $"  Account Balance:{AccBalance, 22:C}\n"+
                   "--------------------------------------------\n";
        }
    }
}
