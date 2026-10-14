using System;
using Tyuiu.IvanovEY.Sprint2.Task6.V15.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января понедельник.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня года (k, от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string result = ds.FindDayName(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* День недели: " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}