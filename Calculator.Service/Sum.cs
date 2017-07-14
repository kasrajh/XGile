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

        public int Add(string parameters)
        {
            if (string.IsNullOrEmpty(parameters))
                return 0;

            char[] separators = { ',', '\n' };
            if (parameters.StartsWith("//"))
            {
                separators[2] = parameters[2];
            }

            string[] param = parameters.Split(separators);
            int sum = 0;
            foreach (var p in param)
            {
                sum += int.Parse(p);
            }
            return sum;
        }

       
    }
}
