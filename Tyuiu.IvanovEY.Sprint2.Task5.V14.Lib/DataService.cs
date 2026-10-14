using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovEY.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int dayNumber = ((d - 1 + (k - 1)) % 7) + 1;
            string dayName = "";

            switch (dayNumber)
            {
                case 1: dayName = "Понедельник"; break;
                case 2: dayName = "Вторник"; break;
                case 3: dayName = "Среда"; break;
                case 4: dayName = "Четверг"; break;
                case 5: dayName = "Пятница"; break;
                case 6: dayName = "Суббота"; break;
                case 7: dayName = "Воскресенье"; break;
                default: dayName = "Ошибка"; break;
            }

            return dayName;
        }
    }
}
