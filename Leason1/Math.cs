using System;
using System.Collections.Generic;
using System.Text;

namespace Leason1
{
    public class Math
    {
        private int Id = 123;
        internal string name;
        protected double Sellary;
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int sum(double num1, int num2)
        {
            return Convert.ToInt32(num1) + num2;
        }
        public int sum(double num1, int num2, int num3)
        {
            return Convert.ToInt32(num1) + num2 + num3;
        }
    }
}
