﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public  interface ICalculator
    {
        decimal Calculate(decimal number1, decimal number2);
    }
}
