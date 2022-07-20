using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8
{
    internal class Calculator
    {
        private double firstOperand;
        private double secondOperand;
        private double result;

        public double FirstOperand
        {
            get { return firstOperand; }
            set { firstOperand = value; }
        }

        public double SecondOperand
        {
            get { return secondOperand; }
            set { secondOperand = value; }
        }

        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public double Addition()
        {
            return result = firstOperand + secondOperand;
        }
    }
}
