using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class AddStringGroup1
    {

        public decimal Add(string text)
        {
            if (!IsInputValid(text))
                return 0;
            else
            {
                var numbers = text.Split(',');

                if (numbers.Length == 1)
                    return System.Convert.ToInt64(numbers[0]);
                else
                {
                    if (numbers.Length == 2)
                    {
                        return System.Convert.ToInt64(numbers[0]) + System.Convert.ToInt64(numbers[1]);
                    }
                    else
                        throw new ArgumentException("تعداد کاراکتر صحیح نیست");
                }
            }
        }

        private bool IsInputValid(string text)
        {
            return (text != "");
        }

        public object AddNumbers(List<decimal> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
