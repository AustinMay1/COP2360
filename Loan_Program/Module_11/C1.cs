using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    internal class C1
    {
        private double loanAmount = 0.0;
        private double years = 0.0;
        private double interests = 0.0;
        private double interestRates = 0.0;


        public double PayInterests(double amount, double length, double rate)
        {
            
            loanAmount = amount;
            years = length;
            interestRates = rate;

            interests = loanAmount * years * interestRates / 100;
            return interests;
        }
    }
}
