using System;
using Tyuiu.IvanovEY.Sprint2.Task0.V11.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, False, True, False), при x = 8105, y = 275          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 8105, y = 275                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int x = 8105;
            int y = 275;

            DataService ds = new DataService();
            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("* (" + result[0] + ", " + result[1] + ", " + result[2] + ", " + result[3] + ", " + result[4] + ", " + result[5] + ")");
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}