using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Sorting
    {
        internal void SortAscending(double[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        internal void SortDescending(double[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return; 
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
