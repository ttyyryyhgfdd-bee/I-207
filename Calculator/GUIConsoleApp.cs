using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    #region Enumberation
    internal enum Operations
    {
        Exit = 0,
        Percent = 1,
        InvPercent = 2,
        Doubledivider = 3,
        Intdivider = 4,
        Multiplication = 5,
        Divider = 6,
        Subtraction = 7,
        Addition = 8,
        Factorial = 9,
        CreateArray = 10,
        Sum = 11,
        Max = 12,
        Min = 13
    }
    #endregion
    internal class GUIConsoleApp
    {
        private Calculator.Math calc = new Calculator.Math();

        internal void Start()
        {
            double[] array = new double[0];//рш фкешщь
            #region Операции
            while (true)
            {
                Console.Write("Выберете номер действия(0,13):\n" +
                    "0 - Выход из программы\n" +
                    "1 - Найти процент\n" +
                    "2 - Найти разницу(в процентах)\n" +
                    "3 - Деление на остаток\n" +
                    "4 - Деление на целое\n" +
                    "5 - Умножение\n" +
                    "6 - Деление\n" +
                    "7 - Вычитание\n" +
                    "8 - Сложение\n" +
                    "9 - Факториал\n" +
                    "10 - Задать массив\n" +
                    "11 - Вывести сумму\n" +
                    "12 - Найти максимум\n" +
                    "13 - Найти минимум\n");

                int actionNumber = Convert.ToInt16(Console.ReadLine());

                Operations action = (Operations)actionNumber;

                if (action == Operations.Exit)
                {
                    break;
                }
                
                while (action != Operations.Exit)
                {
                    if (action == Operations.Exit)
                    {
                        break;
                    }
                    #region Percent
                    else if (action == Operations.Percent)
                    {
                        Console.Write("Введите число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите процент: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Percent(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region InvPercent
                    else if (action == Operations.InvPercent)
                    {
                        Console.Write("Введите начальное число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите конечное число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.InvPercent(num1, num2);
                        Console.Write("Результат: " + result + "%\n");
                    }
                    #endregion
                    #region Div%
                    else if (action == Operations.Doubledivider)
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Doubledivider(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Div//
                    else if (action == Operations.Intdivider)
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Intdivider(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Multiply
                    else if (action == Operations.Multiplication)
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Multiplication(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Div
                    else if (action == Operations.Divider)
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Divider(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Sub
                    else if (action == Operations.Subtraction)
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Subtraction(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Add
                    else if (action == Operations.Addition)
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = calc.Addition(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Factorial
                    else if (action == Operations.Factorial)
                    {
                        Console.Write("Введите число: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int result = calc.Factorial(num1);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Array
                    else if (action == Operations.CreateArray)
                    {
                        Console.Write("Введите размер массива: ");
                        int array_size = Convert.ToInt16(Console.ReadLine());
                        if (array_size < 0)
                        {
                            Console.Write("Размер массива должен быть положительным!\n");
                        }
                        else
                        {
                            array = new double[array_size];
                            for (int counter = 0; array_size > counter; counter += 1)
                            {
                                Console.Write("Введите число: ");
                                array[counter] = Convert.ToDouble(Console.ReadLine());
                            }
                        }
                    }
                    #endregion
                    #region Sum
                    else if (action == Operations.Sum)
                    {
                        double result = calc.Sum(array);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Max
                    else if (action == Operations.Max)
                    {
                        double result = calc.Max(array);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Min
                    else if (action == Operations.Min)
                    {
                        double result = calc.Min(array);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion

                    Console.Write("Хотите снова что-то посчитать? (0 - нет. другое число - да): ");
                    int answer = Convert.ToInt16(Console.ReadLine());
                    if (answer == 0)
                    {
                        action = Operations.Exit;
                    }
                    else
                    {
                        action = Operations.Exit;
                    }
                }
            }
            #endregion
        }
    }
}
    