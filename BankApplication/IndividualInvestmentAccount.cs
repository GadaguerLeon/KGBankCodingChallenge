using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class IndividualInvestmentAccount : Account
    {
        public IndividualInvestmentAccount()
        { 
            this.SetInterestRate(0.04);
            this.SetAccountType("Individual Investment Account");
        }
    }
}
