using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cli_calculator.Models
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Potency(int a, int b)
        {
            int result = Convert.ToInt32(Math.Pow(a, b));
            return result;
        }
    }
}