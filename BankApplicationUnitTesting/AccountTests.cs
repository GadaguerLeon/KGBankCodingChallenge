using BankApplication;
using System;
using Xunit;

namespace BankApplicationUnitTesting
{
    public class AccountTests
    {


        /// <summary>
        /// The Following tests are for the default checking account
        /// </summary>
        [Fact]
        public void Successful_Deposit()
        {
            Account userOneChecking = new Account();
            userOneChecking.SetName("Steve Rogers");
            userOneChecking.SetBalance(3000);
            userOneChecking.SetAccountType("Checking");

            // Tests for successful deposit
            Assert.Equal(3050, userOneChecking.Deposit(50));

            
        }

        [Fact]
        public void Successful_Withdrawal()
        {
            Account userOneChecking = new Account();
            userOneChecking.SetName("Steve Rogers");
            userOneChecking.SetBalance(3000);
            userOneChecking.SetAccountType("Checking");

            // Tests for successful withdrawal
            Assert.Equal(2950, userOneChecking.Withdraw(50));
        }

        [Fact]
        public void Successful_Transfer()
        {
            Account userOneChecking = new Account();
            userOneChecking.SetName("Steve Rogers");
            userOneChecking.SetBalance(3000);
            userOneChecking.SetAccountType("Checking");

            Account userTwoChecking = new Account();
            userTwoChecking.SetName("Tony Stark");
            userTwoChecking.SetBalance(123000);
            userTwoChecking.SetAccountType("Checking");

            int transferAmount = 20;

            userOneChecking.Withdraw(transferAmount);
            userTwoChecking.Deposit(transferAmount);

            // Tests for 20 dollar difference
            Assert.Equal(2980, userOneChecking.GetBalance());
            Assert.Equal(123020, userTwoChecking.GetBalance());


        }

        /// <summary>
        /// The following tests are for the individual investment account
        /// </summary>
        
        [Fact]
        public void Successful_IndividualInvestment_Deposit()
        {
            IndividualInvestmentAccount userOneIndividualInv = new IndividualInvestmentAccount();
            userOneIndividualInv.SetName("Black Widow");
            userOneIndividualInv.SetBalance(4000);

            userOneIndividualInv.Deposit(100);

            // Tests for successful deposit
            Assert.Equal(4100, userOneIndividualInv.GetBalance());

        }

        [Fact]
        public void Successful_IndividualInvestment_Withdrawal()
        {
            IndividualInvestmentAccount userOneIndividualInv = new IndividualInvestmentAccount();
            userOneIndividualInv.SetName("Black Widow");
            userOneIndividualInv.SetBalance(4000);

            userOneIndividualInv.Withdraw(100);

            // Tests for successful withdrawal
            Assert.Equal(3900, userOneIndividualInv.GetBalance());
        }

        [Fact]
        public void Unsuccessful_IndividualInvestment_Withdrawal()
        {
            IndividualInvestmentAccount userOneIndividualInv = new IndividualInvestmentAccount();
            userOneIndividualInv.SetName("Black Widow");
            userOneIndividualInv.SetBalance(4000);

            userOneIndividualInv.Withdraw(600);

            // Test for unsuccessful withdrawal for amounts greater than 500
            Assert.Equal(4000, userOneIndividualInv.GetBalance());
        }

        [Fact]
        public void Successful_IndividualInvestment_Transfer ()
        {
            IndividualInvestmentAccount userOneIndividualInv = new IndividualInvestmentAccount();
            userOneIndividualInv.SetName("Black Widow");
            userOneIndividualInv.SetBalance(4000);

            IndividualInvestmentAccount userTwoIndividualInv = new IndividualInvestmentAccount();
            userTwoIndividualInv.SetName("Thor Odinson");
            userTwoIndividualInv.SetBalance(6000);

            int transferAmount = 100;

            userOneIndividualInv.Withdraw(transferAmount);
            userTwoIndividualInv.Deposit(transferAmount);
            
            // Tests accounts for 100 dollar change
            Assert.Equal(3900, userOneIndividualInv.GetBalance());
            Assert.Equal(6100, userTwoIndividualInv.GetBalance());
        }

        /// <summary>
        /// The following tests are for the corporate investment account
        /// </summary>
        [Fact]
        public void Successful_CorporateInvestment_Deposit()
        {
            CorporateInvestmentAccount userOneCorporateInv = new CorporateInvestmentAccount();
            userOneCorporateInv.SetName("Stark Industries");
            userOneCorporateInv.SetBalance(2988780989);

            userOneCorporateInv.Deposit(300);

            // Tests for successful deposit
            Assert.Equal(2988781289, userOneCorporateInv.GetBalance());
        }

        [Fact]
        public void Successful_CorporateInvestment_Withdrawal()
        {
            CorporateInvestmentAccount userOneCorporateInv = new CorporateInvestmentAccount();
            userOneCorporateInv.SetName("Stark Industries");
            userOneCorporateInv.SetBalance(2988780989);

            userOneCorporateInv.Withdraw(300);

            // Tests for successful withdrawal
            Assert.Equal(2988780689, userOneCorporateInv.GetBalance());
        }

        [Fact]
        public void Successful_CorporateInvestment_Transfer()
        {
            CorporateInvestmentAccount userOneCorporateInv = new CorporateInvestmentAccount();
            userOneCorporateInv.SetName("Stark Industries");
            userOneCorporateInv.SetBalance(2988780989);

            CorporateInvestmentAccount userTwoCorporateInv = new CorporateInvestmentAccount();
            userTwoCorporateInv.SetName("S.H.I.E.L.D");
            userTwoCorporateInv.SetBalance(4000000);

            int transferAmount = 1000000;

            userOneCorporateInv.Withdraw(transferAmount);
            userTwoCorporateInv.Deposit(transferAmount);

            // Tests for a million dollar change
            Assert.Equal(2987780989, userOneCorporateInv.GetBalance());
            Assert.Equal(5000000, userTwoCorporateInv.GetBalance());
        }
    }
}
