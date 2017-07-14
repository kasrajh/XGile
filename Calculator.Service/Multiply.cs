using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class Multiply : ICalculator
    {
        public decimal Calculate(decimal number1, decimal number2)
        {
            CheckArgumant(number1, number2);

            return CalculateMultiple(number1, number2);
        }

        private decimal CalculateMultiple(decimal number1, decimal number2)
        {
            var upperBoundry = 10000;
            if (number1 > upperBoundry || number2 > upperBoundry)
                return 0;
            else
                return number1* number2;
        }

        private static void CheckArgumant(decimal number1, decimal number2)
        {
            if (number1 == 0 || number2 == 0)
                throw new ArgumentException("ورودی صحیح نیست");
        }
    }
}
