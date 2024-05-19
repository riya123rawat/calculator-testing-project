using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_testing
{
    public class Calc
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Addition(params double[] numbers)
        {
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Subtraction(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

}
