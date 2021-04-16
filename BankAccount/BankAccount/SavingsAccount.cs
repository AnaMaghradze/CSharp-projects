using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount
    {
        // auto-implemented properties 
        public string AccNumber { get; set; }
        public string AccName { get; set; }
        private double interestRate;
        private decimal accBalance;
        
        public double InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                if(value >= 0)
                {
                    interestRate = value; // Interest rate must be positive
                }
            }

        }       

        public decimal AccBalance
        {
            get
            {
                return accBalance;
            }
            set
            {
                if(value >= 0)
                {
                    accBalance = value; // Balance must be positive
                }
                else
                {
                    Console.WriteLine("\nInsufficient Amount!"); // if balance is negative
                }
            }
        }

        // explicit value constructor
        public SavingsAccount(string accName, string accNumber, double interestRate, decimal accBalance)
        {
            AccName = accName;
            AccNumber = accNumber;
            this.interestRate = interestRate;
            this.accBalance = accBalance;
        }

        // override ToString()
        public override string ToString()
        {
            return "";
        }
    }
}
