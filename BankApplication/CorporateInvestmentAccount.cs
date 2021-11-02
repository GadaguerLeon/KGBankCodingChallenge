using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class CorporateInvestmentAccount : Account
    {
        public CorporateInvestmentAccount()
        {
            this.SetInterestRate(0.08);
            this.SetAccountType("Corporate Investment Account");
        }
    }
}
