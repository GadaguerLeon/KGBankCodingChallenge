using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        private string name;
        private double balance = 0;
        private double interestRate;
        private string accountType = "";
        
        // Getter and setter for name
        public string GetName()
        {
            return this.name;
        }

        public void SetName (string name)
        {
            this.name = name;
        }

        // Getter and setter for account balance
        public double GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(double amount)
        {
            this.balance = amount;
        }

        // Getter and setter for the account type

        public string GetAccountType()
        {
            return this.accountType;
        }

        public void SetAccountType(string accountType)
        {
            this.accountType = accountType;
        }

        // Getter and setter for the interest rate 
        public void SetInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public double GetInterestRate()
        {
            return this.interestRate;
        }

        public double Deposit(double amount)
        {        
            this.balance += amount;
            return this.balance;
        }

        public double Withdraw(double amount)
        {

            if (this.balance > amount)
            {
                if (this.accountType == "Individual Investment Account" && amount > 500)
                {
                        Console.WriteLine("Individual investment account withdrawal limit is $500");
                }
                else
                {
                    this.balance -= amount;
                }
                
            } else
            {
                Console.WriteLine("Insufficient funds. Unable to complete transaction.");
            }
            return this.balance;
        }

        
    }
}
