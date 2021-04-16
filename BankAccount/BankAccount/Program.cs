using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Ana Maghradze
/// 823356346
/// </summary>

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string accName = "";
            string accNumber = "";
            double interestRate = 3;
            decimal accBalance = 0;
            // List of accounts
            List<CDAccount> accounts = new List<CDAccount>()
            {
                // initially added one account in list
                new CDAccount("Ana Maghradze", "GE1111", interestRate, 6500) 
            };
            
            var sentinel = true;
            Console.WriteLine("<< WELCOME! >>\n");
            do{ 
                Console.WriteLine("\n1 - Sign In");
                Console.WriteLine("2 - Create Account");
                Console.WriteLine("3 - See List of Accounts");
                Console.WriteLine("4 - Exit\n");

                bool valid = false;
                string choice = Console.ReadLine();                

                if(choice == "1")
                {
                    CDAccount A1 = new CDAccount(accName, accNumber, interestRate, accBalance);
                    Console.Write($"Enter Your Account Number: ");
                    accNumber = Console.ReadLine();
                    // if such account exists, show information about the account
                    foreach(var account in accounts)
                    {
                        if(account.AccNumber == accNumber)
                        {
                            Console.WriteLine($"\nHello, {account.AccName}. ");
                            A1 = account;
                            Transactions(A1); // for deposits or withdrawals
                            valid = true;
                            break;
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                    // if account doesn't exist - go to menu
                    if (valid == false)
                    {
                        Console.Write("\nAccount Not Found!\n");
                    }
                    else
                    {
                        Console.Write("");
                    }                
                }
                else if(choice=="2")
                {
                    // creating new account and adding to the list of accounts
                    Console.Write($"\nCreate A New Account: \n");
                    Console.Write($"Account Name: ");
                    accName = Console.ReadLine();
                    Console.Write($"Account Number: ");

                    // check if such account number exists already
                    var check = false; 
                    do
                    {
                        accNumber = Console.ReadLine();
                        foreach (var account in accounts)
                        {
                            if (account.AccNumber == accNumber)
                            {
                                Console.WriteLine($"Account Number Is Already Taken. Try Other...");
                                Console.Write($"Account Number: ");
                                check = true;
                            }
                            else
                            {
                                check = false;
                            }                            
                        }
                     } while (check);
                
                    Console.Write($"Initial Balance: ");  //  getting initial balance from user
                    accBalance = decimal.Parse(Console.ReadLine());

                    // create new object
                    CDAccount A = new CDAccount(accName, accNumber, interestRate, accBalance);
                    accounts.Add(A); //add new account to the list of accounts
                    Console.WriteLine("\nAccount Successfully Created.");
                    // call function transactions to deposit or withdraw money
                    Transactions(A);
                }
                else if (choice == "3")
                {
                    // display all acounts from the list
                    Console.WriteLine("The List Of All Accounts:\n");

                    // using LINQ to query accounts ordered by their balances in decending order
                    var list =
                            from value in accounts
                            orderby value.AccBalance descending
                            select new { Account = value.AccName, Balance = value.AccBalance };

                    // display each account
                    foreach (var account in list)
                    {
                            Console.WriteLine(account);
                    }
                }
                else if (choice == "4")
                {
                    sentinel = false;  // exit
                }
                else
                {
                    Console.Write("");
                }            

            } while(sentinel);

            // this function is used to suggest user to deposit or withdraw money
            void Transactions(CDAccount account)
            {
                var answer = "";
                do
                {
                    Console.WriteLine($"Your Account Status: \n{account}"); // display account info
                    Console.WriteLine("Press <<D>> to Deposit Money");
                    Console.WriteLine("Press <<W>> to Withdraw Money");
                    Console.WriteLine("Press Any Key to Return to Menu");
                    answer = Console.ReadLine();

                    if (answer == "D" || answer == "d")
                    {
                        // catching exceptions in case of invalid inputs
                        try
                        {
                            account.Deposit(DateTime.Now);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Amount For The Deposit Must Be Positive.");
                        }
                    }
                    else if (answer == "W" || answer == "w")
                    {
                        // catching exceptions in case of invalid inputs
                        try
                        {
                            account.Withdraw(DateTime.Now);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Amount For The Withdrawal Must Be Positive.");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Not Suffitient Amount For Withdrawal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                } while (answer == "D" || answer == "d" || answer == "W" || answer == "w");
            }
        }
    }
}
