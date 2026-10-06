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
        Multiplication = 4,
        Divider = 5,
        Subtraction = 6,
        Addition = 7,
        Factorial = 8,
        CreateArray = 9,
        Sum = 10,
        Max = 11,
        Min = 12
    }
    #endregion

    internal class GUIConsoleApp
    {
        internal Calculator.Math calc = new Calculator.Math();
        #region Защита
        internal double ReadDoubleSafe(string message)
        {
            double result;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Введено некорректное значение. Пожалуйста, введите число.");
                Console.Write(message);
            }
            return result;
        }

        internal int ReadIntSafe(string message)
        {
            int result;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Введено некорректное значение. Пожалуйста, введите целое число.");
                Console.Write(message);
            }
            return result;
        }
        #endregion
        internal void Start()
        {
            double[] array = null;

            #region Операции
            while (true)
            {
                #region Menu
                Console.Write("Выберете номер действия(0,12):\n" +
                    "0 - Выход из программы\n" +
                    "1 - Найти процент\n" +
                    "2 - Найти разницу(в процентах)\n" +
                    "3 - Деление на остаток\n" +
                    "4 - Умножение\n" +
                    "5 - Деление\n" +
                    "6 - Вычитание\n" +
                    "7 - Сложение\n" +
                    "8 - Факториал\n" +
                    "9 - Задать массив\n" +
                    "10 - Вывести сумму\n" +
                    "11 - Найти максимум\n" +
                    "12 - Найти минимум\n" +
                    "----------------------------\n");
                #endregion

                int actionNumber;
                while (!int.TryParse(Console.ReadLine(), out actionNumber) || actionNumber < 0 || actionNumber > 12)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Введите целое число от 0 до 12.");
                    Console.Write("Выберете номер действия(0,12):\n0 - Выход...\n[повторите ввод]: ");
                }

                Operations action = (Operations)actionNumber;
                if (action == Operations.Exit)
                {
                    break;
                }

                while (action != Operations.Exit)
                {
                    #region Percent
                    if (action == Operations.Percent)
                    {
                        double num1 = ReadDoubleSafe("Введите число: ");
                        double num2 = ReadDoubleSafe("Введите процент: ");
                        double result = calc.Percent(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region InvPercent
                    else if (action == Operations.InvPercent)
                    {
                        double num1 = ReadDoubleSafe("Введите начальное число: ");
                        double num2 = ReadDoubleSafe("Введите конечное число: ");
                        double result = calc.InvPercent(num1, num2);
                        Console.Write("Результат: " + result + "%\n");
                    }
                    #endregion
                    #region Div%
                    else if (action == Operations.Doubledivider)
                    {
                        double num1 = ReadDoubleSafe("Введите первое число: ");
                        double num2 = ReadDoubleSafe("Введите второе число: ");
                        double result = calc.Doubledivider(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Multiply
                    else if (action == Operations.Multiplication)
                    {
                        double num1 = ReadDoubleSafe("Введите первое число: ");
                        double num2 = ReadDoubleSafe("Введите второе число: ");
                        double result = calc.Multiplication(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Div
                    else if (action == Operations.Divider)
                    {
                        double num1 = ReadDoubleSafe("Введите первое число: ");
                        double num2 = ReadDoubleSafe("Введите второе число: ");
                        double result = calc.Divider(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Sub
                    else if (action == Operations.Subtraction)
                    {
                        double num1 = ReadDoubleSafe("Введите первое число: ");
                        double num2 = ReadDoubleSafe("Введите второе число: ");
                        double result = calc.Subtraction(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Add
                    else if (action == Operations.Addition)
                    {
                        double num1 = ReadDoubleSafe("Введите первое число: ");
                        double num2 = ReadDoubleSafe("Введите второе число: ");
                        double result = calc.Addition(num1, num2);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Factorial
                    else if (action == Operations.Factorial)
                    {
                        int num1 = ReadIntSafe("Введите число: ");
                        int result = calc.Factorial(num1);
                        Console.Write("Результат: " + result + "\n");
                    }
                    #endregion
                    #region Array
                    else if (action == Operations.CreateArray)
                    {
                        int array_size;
                        Console.Write("Введите размер массива: ");
                        while (!int.TryParse(Console.ReadLine(), out array_size) || array_size <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Ошибка! Размер массива должен быть целым числом больше 0.");
                            Console.Write("Введите размер массива: ");
                        }

                        array = new double[array_size];
                        for (int counter = 0; array_size > counter; counter += 1)
                        {
                            array[counter] = ReadDoubleSafe($"Введите число для элемента [{counter}]: ");
                        }
                    }
                    #endregion
                    #region Sum
                    else if (action == Operations.Sum)
                    {
                        if (array == null || array.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Защита: Сначала необходимо задать массив (пункт 9)!");
                        }
                        else
                        {
                            double result = calc.Sum(array);
                            Console.Write("Результат: " + result + "\n");
                        }
                    }
                    #endregion
                    #region Max
                    else if (action == Operations.Max)
                    {
                        if (array == null || array.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Защита: Сначала необходимо задать массив (пункт 9)!");
                        }
                        else
                        {
                            double result = calc.Max(array);
                            Console.Write("Результат: " + result + "\n");
                        }
                    }
                    #endregion
                    #region Min
                    else if (action == Operations.Min)
                    {
                        if (array == null || array.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Защита: Сначала необходимо задать массив (пункт 9)!");
                        }
                        else
                        {
                            double result = calc.Min(array);
                            Console.Write("Результат: " + result + "\n");
                        }
                    }
                    #endregion

                    Console.Write("Хотите снова что-то посчитать? (0 - нет. другое число - да): ");
                    int answer;
                    while (!int.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.Clear();
                        Console.WriteLine("Ошибка! Введите целое число.");
                        Console.Write("Хотите снова что-то посчитать? (0 - нет. другое число - да): ");
                    }
                    if (answer == 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        action = Operations.Exit;
                    }
                }
            }
            #endregion
        }
    }
}