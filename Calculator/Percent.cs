using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Math
    {
        #region Percent
        internal double Percent(double num1, double num2) => num1 * (num2 / 100);
        #endregion
        #region InvPercent
        internal double InvPercent(double num1, double num2)
        {
            if (num1 == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль.");
                return 0;
            }
            else
            {
                return ((num2 - num1) / num1) * 100;
            }
        }
        #endregion
        #region Multiply
        internal double Multiplication(double num1, double num2) => num1 * num2;
        #endregion
        #region Sub
        internal double Subtraction(double num1, double num2) => num1 - num2;
        #endregion
        #region Add
        internal double Addition(double num1, double num2) => num1 + num2;
        #endregion
        #region Factorial
        internal int Factorial(int num1)
        {
            int result = 1;
            while (num1 > 1)
            {
                result = result * num1;
                num1--;
            }
            return result;
        }
        #endregion
        #region Div
        internal double Divider(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
        #endregion
        #region Div//
        internal double Intdivider(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль");
                return 0;
            }
            else
            {
                return (int)(num1 / num2);
            }
        }
        #endregion
        #region Div%
        internal double Doubledivider(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль");
                return 0;
            }
            else
            {
                return num1 % num2;
            }
        }
        #endregion
        #region Count
        internal int Count(double[] count) => count.Length;
        #endregion
        #region Sum
        internal double Sum(double[] numbers)
        {
            var total = 0.0;
            foreach (var i in numbers)
            {
                total += i;
            }
            return total;
        }
        #endregion
        #region Max
        internal double Max(double[] numbers)
        {
            double max_number = numbers[0];
            foreach (double i in numbers)
            {
                if (i > max_number)
                {
                    max_number = i;
                }
            }
            return max_number;
        }
        #endregion
        #region Min
        internal double Min(double[] numbers)
        {
            double min_number = numbers[0];
            foreach (double i in numbers)
            {
                if (i < min_number)
                {
                    min_number = i;
                }
            }
            return min_number;
        }
        #endregion
    }
}
