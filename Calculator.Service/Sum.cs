using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class Sum : ICalculator
    {
        public decimal Calculate(decimal number1, decimal number2)
        {
            return number1 + number2;
        }
    }
}
