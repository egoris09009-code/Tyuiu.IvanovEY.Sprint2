using System;
using Tyuiu.IvanovEY.Sprint2.Task1.V19.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, False, True, False), при a = 696, b = 354,          *");
            Console.WriteLine("* c = 423, d = 957                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 696, b = 354, c = 423, d = 957                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;

            DataService ds = new DataService();
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("* (" + result[0] + ", " + result[1] + ", " + result[2] + ", " + result[3] + ", " + result[4] + ", " + result[5] + ")");
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}