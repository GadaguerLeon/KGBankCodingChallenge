using System;
using System.Collections.Generic;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> bankAccounts = new List<Account>();

            Account userOneChecking = new Account();
            userOneChecking.SetName("Tony Stark");
            userOneChecking.SetBalance(123000);
            userOneChecking.SetAccountType("Checking");

            IndividualInvestmentAccount userTwoIndividualInv = new IndividualInvestmentAccount();
            userTwoIndividualInv.SetName("Black Widow");
            userTwoIndividualInv.SetBalance(4000);

            CorporateInvestmentAccount userThreeCorporateInv = new CorporateInvestmentAccount();
            userThreeCorporateInv.SetName("Stark Industries");
            userThreeCorporateInv.SetBalance(2988780989);

            

            bankAccounts.Add(userOneChecking);
            bankAccounts.Add(userTwoIndividualInv);
            bankAccounts.Add(userThreeCorporateInv);


            Console.WriteLine("Welcome to KG Bank!");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1 - View Balance");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Withdraw");
            Console.WriteLine("4 - Transfer");
            Console.WriteLine("5 - Terminate");

            int option = int.Parse(Console.ReadLine());
            while (true)
            {
                if (option == 1)
                {
                    Console.WriteLine("Enter your name: ");
                    string nameCheck = Console.ReadLine();
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (nameCheck == bankAccounts[i].GetName())
                        {
                            Console.WriteLine("Account Found!\n" +
                                              "Name: {0}\n" +
                                              "Account Type: {1}\n" +
                                              "Available balance: {2}", bankAccounts[i].GetName(), bankAccounts[i].GetAccountType(), bankAccounts[i].GetBalance());
                        }       
                    }
                    Console.ReadLine();
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter your name: ");
                    string nameCheck = Console.ReadLine();
                    bool present = false;
                    int accountIndex = 0;
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (nameCheck == bankAccounts[i].GetName())
                        {
                            accountIndex = i;
                            present = true;
                        }
                    }
                    if (present)
                    {
                        Console.Write("Enter amount to deposit: ");
                        bankAccounts[accountIndex].Deposit(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Current Balance: $" + bankAccounts[accountIndex].GetBalance());
                    }
                    else
                    {
                        Console.WriteLine("Account not found!");
                    }
                    Console.ReadLine();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter your name: ");
                    string nameCheck = Console.ReadLine();
                    bool present = false;
                    int accountIndex = 0;
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (nameCheck == bankAccounts[i].GetName())
                        {
                            accountIndex = i;
                            present = true;
                        }
                    }
                    if (present)
                    {
                        Console.Write("Enter amount to withdraw: ");
                        bankAccounts[accountIndex].Withdraw(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Current Balance: $" + bankAccounts[accountIndex].GetBalance());
                    }
                    else
                    {
                        Console.WriteLine("Account not found!");
                    }
                    Console.ReadLine();
                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter your name: ");
                    string userOneNameCheck = Console.ReadLine();
                    bool userOnePresent = false;
                    int userOneAccountIndex = 0;
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (userOneNameCheck == bankAccounts[i].GetName())
                        {
                            userOneAccountIndex = i;
                            userOnePresent = true;
                        }
                    }
                    Console.Write("Enter the name of the user you would like to send money to: ");
                    string userTwoNameCheck = Console.ReadLine();
                    bool userTwoPresent = false;
                    int userTwoAccountIndex = 0;
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (userTwoNameCheck == bankAccounts[i].GetName() && userOneNameCheck != userTwoNameCheck)
                        {
                            userTwoAccountIndex = i;
                            userTwoPresent = true;
                        }
                    }

                    if (userOnePresent && userTwoPresent)
                    {
                        Console.WriteLine("Enter the amount you would like to transfer to " + bankAccounts[userTwoAccountIndex].GetName() + ": ");
                        double transferAmount = double.Parse(Console.ReadLine());
                        bankAccounts[userOneAccountIndex].Withdraw(transferAmount);
                        bankAccounts[userTwoAccountIndex].Deposit(transferAmount);
                        Console.WriteLine("Transfer successful!");
                        Console.WriteLine("You've sent ${0} to {1}", transferAmount, bankAccounts[userTwoAccountIndex].GetName());
                        Console.WriteLine("Current Balance: $" + bankAccounts[userOneAccountIndex].GetBalance());
                    }

                    if (!userOnePresent || !userTwoPresent)
                    {
                        Console.WriteLine("Please make sure both names are spelled correctly and try again.");
                    }

                }
                else if (option == 5)
                {
                    break;
                }
            }
        }
    }
}
